using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public enum Status
    {
        ACTIVE,
        NOT_ACTIVE,
        SUCCESS,
        FAILED,
        COMPLETE,
        NOT_COMPLETE,
        NODATA,
        ERROR
    }
    public enum UserMode
    {
        ADMIN,
        USER
    }
}
