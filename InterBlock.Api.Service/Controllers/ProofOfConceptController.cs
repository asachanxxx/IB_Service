/*
 Author      : S.G Asanga Chandrakumara
 Purpose     : To proof of the concept of repository usage of accessing data of any given object type.
 DateCreated : 21/10/2019 
 DateModified: 21/10/2019
 Note:       : This is a api that was created using the repositories. so coeder does not need to know about hirachical implimentation of the DATABASE TYPE 
                
 */
using InterBlock.BI.Models;
using InterBlock.Helpers.Utilities;
using InterBlock.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace InterBlock.Api.Service.Controllers
{
    [RoutePrefix("pofc")]
    public class ProofOfConceptController : ApiController
    {
        ExtendedRepository<Accounts> _repo;
        public ProofOfConceptController()
        {
            
            _repo = new ExtendedRepository<Accounts>(new Helpers.Configurations.IBConfiguration() { Connection = new Helpers.Configurations.Connections(System.Configuration.ConfigurationManager.ConnectionStrings["SysConSQL"].ConnectionString ), DbType = Helpers.Enums.DataBaseType.MSSql }, "Accounts");
        }


        /******************************************************************************************************************************************************************************
         * Following set of methods will use the Extended repositories passing class type transactions    
         * these can use to minipulate data for any given object and corresponding table must be there in the database of supplied connection
         * Only passing class related data can be minipulated using these set of methods
         *******************************************************************************************************************************************************************************/

        [HttpPost]
        [Route("SaveSingle")]
        public async Task<HttpResponseMessage> SaveSingle(Accounts Entity)
        {
            try
            {
                
                return Request.CreateResponse<int>(HttpStatusCode.OK, await _repo.SaveSingle(Entity, 1));
            }
            catch (Exception ex)
            {
                
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("ModifySingle")]
        public async Task<HttpResponseMessage> ModifySingle(Accounts Entity)
        {
            try
            {
                return Request.CreateResponse<bool>(HttpStatusCode.OK, await _repo.ModifySingle(Entity));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("DeleteSingleWithObject")]
        public async Task<HttpResponseMessage> DeleteSingleWithObject(Accounts Entity)
        {
            try
            {
                return Request.CreateResponse<bool>(HttpStatusCode.OK, await _repo.DeleteSingle(Entity));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("DeleteSingleWithPK")]
        public async Task<HttpResponseMessage> DeleteSingleWithPK(int Entity)
        {
            try
            {
                return Request.CreateResponse<bool>(HttpStatusCode.OK, await _repo.DeleteSingle(Entity));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("DeleteMulti")]
        public async Task<HttpResponseMessage> DeleteMulti(IEnumerable<Accounts> Entity)
        {
            try
            {
                return Request.CreateResponse<bool>(HttpStatusCode.OK, await _repo.DeleteMulti(Entity));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("FindALLRecords")]
        public async Task<HttpResponseMessage> FindALLRecords()
        {
            try
            {
                var IP = HttpHelpers.GetClientIp(Request);

                return Request.CreateResponse<IEnumerable<Accounts>>(HttpStatusCode.OK, await _repo.FindALLRecords());
            }
            catch (Exception ex)
            {
                Logger.LogExceptionOnControllers(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


       

        [HttpGet]
        [Route("FindOneRecord")]
        public async Task<HttpResponseMessage> FindOneRecord(int _FK_value)
        {
            try
            {
                return Request.CreateResponse<Accounts>(HttpStatusCode.OK, await _repo.FindOneRecord(_FK_value));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        /************************************************ QueryProcessor **************************************************************************************************************
        * Following set of methods will use the Extended repositorie's Extended data assecing method . can be pass any kind of object and return any kind of object
        * these can use to minipulate data for any type of query and Excute commands directly in Database.
        * Types will cast automatically back and forth and only requested data will be returning from the methods
        * Right type of method need to be used when handling data with the QueryProcessor. practise by accessing different kind of data will help
        *******************************************************************************************************************************************************************************/


        /// <summary>
        /// You can get a list of given object type by passing SQL statement
        /// Sample SQL would be
        /// SELECT  Id ,CARD_NO ,ACCOUNT_NO,BANK_CODE,BRANCH_CODE FROM Accounts WHERE ACCOUNT_NO = '99347899-2--300093784'
        /// </summary>
        /// <param name="SQL">SQL to pass to get result</param>
        /// <returns> IEnumerable List of class type AccountsEssentialsVM</returns>
        [HttpGet]
        [Route("QueryMultipleUsingSQLStatement")]
        public async Task<HttpResponseMessage> QueryMultipleUsingSQLStatement(string SQL)
        {
            try
            {
                //note that this sql is passed to demostrate this concept. but in real sinario you should encapsulate business requirments and these methods only accept Models or ViewModels or Primirive values
                return Request.CreateResponse<IEnumerable<AccountsEssentialsVM>>(HttpStatusCode.OK, await _repo.QueryProcessor.QueryMultipleUsingSQLStatement<AccountsEssentialsVM>(SQL));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        /// <summary>
        /// You can get a list of given object type by passing Stored Procedure
        /// Sample SQL would be
        /// SP_Process_GetAccountsEssentialsVM
        /// </summary>
        /// <param name="SQL">Stored Procedure to pass to get result</param>
        /// <returns> IEnumerable List of class type AccountsEssentialsVM</returns>
        [HttpGet]
        [Route("QueryMultipleUsingStoredProcedure")]
        public async Task<HttpResponseMessage> QueryMultipleUsingStoredProcedure(string StoredProcedure)
        {
            try
            {
                //note that this sql is passed to demostrate this concept. but in real sinario you should encapsulate business requirments and these methods only accept Models or ViewModels or Primirive values
                return Request.CreateResponse<IEnumerable<AccountsEssentialsVM>>(HttpStatusCode.OK, await _repo.QueryProcessor.QueryMultipleUsingStoredProcedure<AccountsEssentialsVM>(StoredProcedure));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        /// <summary>
        /// You can get a SINGLE OBJECT OF given type by passing SQL statement
        /// Sample SQL would be
        /// SELECT  Id ,CARD_NO ,ACCOUNT_NO,BANK_CODE,BRANCH_CODE FROM Accounts WHERE ACCOUNT_NO = '99347899-2--300093784' 
        /// </summary>
        /// <param name="SQL">Stored Procedure to pass to get result</param>
        /// <returns> IEnumerable List of class type AccountsEssentialsVM</returns>
        [HttpGet]
        [Route("QuerySingleUsingSQLStatement")]
        public async Task<HttpResponseMessage> QuerySingleUsingSQLStatement(string SQL)
        {
            try
            {
                //note that this sql is passed to demostrate this concept. but in real sinario you should encapsulate business requirments and these methods only accept Models or ViewModels or Primirive values
                return Request.CreateResponse<AccountsEssentialsVM>(HttpStatusCode.OK, await _repo.QueryProcessor.QuerySingleUsingSQLStatement<AccountsEssentialsVM>(SQL));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        /// <summary>
        /// You can get a SINGLE OBJECT OF given type by passing Stored Procedure
        /// Sample SQL would be
        /// SELECT  Id ,CARD_NO ,ACCOUNT_NO,BANK_CODE,BRANCH_CODE FROM Accounts WHERE ACCOUNT_NO = '99347899-2--300093784' 
        /// </summary>
        /// <param name="SQL">Stored Procedure to pass to get result</param>
        /// <returns> IEnumerable List of class type AccountsEssentialsVM</returns>
        [HttpGet]
        [Route("QuerySingleUsingSQLStatement")]
        public async Task<HttpResponseMessage> QuerySingleUsingStoredProcedure(string StoredProcedure)
        {
            try
            {
                //note that this sql is passed to demostrate this concept. but in real sinario you should encapsulate business requirments and these methods only accept Models or ViewModels or Primirive values
                return Request.CreateResponse<AccountsEssentialsVM>(HttpStatusCode.OK, await _repo.QueryProcessor.QuerySingleUsingStoredProcedure<AccountsEssentialsVM>(StoredProcedure));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

       



    }
}
