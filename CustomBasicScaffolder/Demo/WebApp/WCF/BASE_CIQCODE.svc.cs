using Repository.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebApp.Services;

namespace WebApp.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BASE_CIQCODE" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BASE_CIQCODE.svc or BASE_CIQCODE.svc.cs at the Solution Explorer and start debugging.
    public class BASE_CIQCODE : IBASE_CIQCODE
    {
        private readonly IBASE_CIQCODEService _bASE_CIQCODEService;
        private readonly IUnitOfWorkAsync _unitOfWork;
        public BASE_CIQCODE()
        {

        }
        public BASE_CIQCODE(IBASE_CIQCODEService  bASE_CIQCODEService, IUnitOfWorkAsync unitOfWork)
        {
            _bASE_CIQCODEService  = bASE_CIQCODEService;
            _unitOfWork = unitOfWork;
        
        }
        public void DoWork()
        {
            var item = _bASE_CIQCODEService.Queryable().FirstOrDefault();
            item.CIQNAME = item.CIQNAME + "__";
            _bASE_CIQCODEService.Update(item);
            _unitOfWork.SaveChanges();
        }


        public IEnumerable<Models.BASE_CIQCODE> GetData()
        {
             return    _bASE_CIQCODEService.Queryable();
        }
    }
}
