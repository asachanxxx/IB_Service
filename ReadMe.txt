ReadMe
======

SetUP
=====

-No need to Update Nuget packages since i send full source code.
- Please install .net Freamwork 4.6.1 if it already not there
- this is a partial implementation only implemented the MSSQL side (Postgate and MYSQL are same as this. but DB2 will be differ than this.)
- to create database in MSSQL side use EF migrations in project InterBlock.DataEngine.EF . before doing this delete Migrations folder on same project 
   after migration set
	 AutomaticMigrationsEnabled = true;
   in newly created Configuration file and update the database. 

   Commands (run these via package manager console )
   =================================================
   1. Enable-Migrations  (this will enable migration with MsSQL. please check Connection string in app.config if any errors)   
   2. Update-Database -f -script (will show the SQL scripts that run against SQL database . Remove -script flag and run again to create database)	

  ** InterBlock.DataEngine.EF need to set as startup when running migrations	
  ** InterBlock.Api.Service need to se startup to run the project

use postman to test the end points(end points was added to the end of this doc)

	   

Basic Architecture
==================
The purpose arise is that we need following things
	- Central data accessing engine that don't depend on a database type
	- Encapsulate data accessing functionalities from the Business process 
	- Use fully OOD and OOP aproche to code resuse and minimize Development time.
	- Use of fluent api calls and Software Design patterns
		-Used Respository pattern
		-Can use adapter pattern and singleton pattern when actually using this
	- Most of the time one line data accessing and this will let developers to more forcus on the Business logic and less worry about 	  data			
	- One restfull service for all SOA needs
		-Web applications
		-Windows and Wpf applications
		-Mobile applications
		-Vertually any application that use HTTP protocol can use these services.

DataEngine Basics
=================
--Used Contextual approche here. we have 4 independent contexts for each DB type. so Genaric version of data accessing can be implement here
the reason we have used 4 separate contexts is that each database type has different Data minipulation techniqes. 

--all contexts are implementing interface 

	iDBContextExtendedBase

  This will make them brothers and will have same behavior. and this interface has all the genaric data access method that common to all the contexts and can be minipulated using all database types.

  EX: 
  Task<IEnumerable<TOut>> QueryTypedStoredProcedure<TPassing, TOut>(string SPName, TPassing Object) where TOut : class where TPassing : class;

--in this method you will get a IEnumerable<TOut> list where TOut will be any class type or view model that you want to get as a result after excuting a stored procedure.
and this SP will need a set of input parameters and we will pass them as TPassing object
using this you can query any kind of data for any requirments

--So like this we would need carfully implement the Genaric Methods that mostly used in day today apps. i here implemented some of the most hitted methods. and rest are we can implement later

-- after fully implementing this we can separate this project and make a DLL or Nuget package out of that and put in a common GIT or SVN repo.
	
-- if later anything need to add we can use the technique call "Extended methods" to plug required methods to exisitng DLLs. so once created no need to be changed.

	https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
--


InterBlock.BI.Models
===================

This will contain the models of the system . exact replica of our Database. if any changes to this need to update on the Database side. at any given time all the models
need to match one to one schema wise.


Repositories (InterBlock.Repositories.Base)
==========================================

a Repository is a set of related functionalities of a given entity. for example a customer entity or model has
	- CRUD
	- Access customer data via SP's
	- Run Joined queries 

so we need some place to get these genaric methods (will common for all models). that is a repository.This will evaluate as follows

	--Genaric Repository Interface (iRepositoryBase)
		--Repository Implementation (ExtendedRepository)
			--Model Wise Repositories(AccountRepository)

iRepositoryBase contain basic CRUD functionalities For a given class type. 

	 public interface iRepositoryBase<T> where T : class  T= any model class not VMs

ExtendedRepository

	public class ExtendedRepository<T> : DBContextExtendedBase, iRepositoryBase<T> where T : class

ExtendedRepository is a class where it inherit from DBContextExtendedBase and implements iRepositoryBase and accept a model class.
the reason it inherits from DBContextExtendedBase  is that we can give it extra functionalities (Extend the api). once you debug the code this will be understood.



Task based asyncronisation
==========================

   public async Task<int> SaveSingle(T Entity, int Action)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_config.Connection._ConnectionString))
                {
                    var _ret_val = await db.InsertAsync(Entity);
                    return  _ret_val;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


Imagine T = Product Class of the Model Project

here i've used async pipe so any no of requests can be taken and distributed to thread pool and handled by a separate thread.

db.DeleteAsync(Entity);

this is dapper Micro ORM(Fast and relaible , StackOverflow was created using this)
https://dapper-tutorial.net/dapper

what it does is that it accept Product type of object called  Entity and excute the Insert command directly to SQL Connection

db.InsertAsync(Entity);

this is much powefullt techniqe and will be needing much more line of code if done using ADO.net. and yet fast close to ado.net. 

Dapper namespace will use extended Methods to Futhure extend the functionality of the SqlConnection.


Rest Services(InterBlock.Api.Service)
==================================== 

those repositoried will be used in this services. it not only can use web api but in Asp.net MVC , Win Forms  ,WPF directly as well.

 public class ProofOfConceptController : ApiController
    {
        ExtendedRepository<Accounts> _repo;
        public ProofOfConceptController()
        {
            _repo = new ExtendedRepository<Accounts>(new Helpers.Configurations.IBConfiguration() { Connection = new Helpers.Configurations.Connections(System.Configuration.ConfigurationManager.ConnectionStrings	    ["SysConSQL"].ConnectionString ), DbType = Helpers.Enums.DataBaseType.MSSql }, "Accounts");
        }

ExtendedRepository<Accounts> _repo;
we create a instance of ExtendedRepository repo using Accounts class. soon as you created this it will have ability of both
	- iRepositoryBase CRUD functions
	- iDBContextExtendedBase extended functionalities
and you can use any of these methods via Accounts object(s)


ExtendedRepository<Accounts> _repo  does not know about how data will handle and what is the end Database type. so it will hide all the behinds and create proper Encapsulation / abstractions combo.





REST API End Points
===================
-------------------


To Save a sigale Record
=======================
http://{Server Name:port}/pofc/SaveSingle
Sample Data To Pass(Json Object)
--------------------------------
{
  "Id": 1,
  "CARD_NO": "123632342234",
  "ACCOUNT_NO": "023423423424",
  "BANK_CODE": "23",
  "BRANCH_CODE": "25",
  "ACCOUNT_TYPE": "sample string 6",
  "CURRENCY_CODE": "sample string 7",
  "NODE_ID": "sample string 8",
  "STATUS_CODE": "sample string 9",
  "ADDED_BY": "sample string 10",
  "ADDED_DATE": "sample string 11",
  "MODIFIED_BY": "sample string 12",
  "MODIFIED_DATE": "sample string 13",
  "LNK_NO": "sample string 14",
  "DISPLAY_ACCT_LABEL": "sample string 15"
}

To Get All Records
==================
http://{Server Name:port}/pofc/FindALLRecords

To Get one record using Primary Key
===================================
http://{Server Name:port}/pofc/FindOneRecord?_FK_value=1


To Get List Of View Model Object directly from SQL Statement
============================================================
http://{Server Name:port}/pofc/QueryMultipleUsingSQLStatement?SQL=SELECT  Id ,CARD_NO ,ACCOUNT_NO,BANK_CODE,BRANCH_CODE FROM Accounts WHERE ACCOUNT_NO = '23442434234'

***Pls note that this sql passing will never done in a real senario. this is only for demostrate the conecept 




To Get List Of View Model Object directly from Stored procedure
=================================================================
http://{Server Name:port}/pofc/QueryMultipleUsingStoredProcedure?StoredProcedure=SP_Process_GetViewModel

***Pls note that this sql passing will never done in a real senario. this is only for demostrate the conecept 





