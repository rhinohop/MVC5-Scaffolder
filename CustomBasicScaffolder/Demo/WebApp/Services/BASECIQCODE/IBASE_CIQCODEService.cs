

     
 
 

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Repository.Pattern.Repositories;
using Service.Pattern;
using WebApp.Models;
using WebApp.Repositories;
using System.Data;
using System.IO;
using System.ServiceModel;

namespace WebApp.Services
{

    [ServiceContract]
    public interface IBASE_CIQCODEService:IService<BASE_CIQCODE>
    {

        [OperationContract]
        IEnumerable<BASE_CIQCODE> Get();

        [OperationContract]
		void ImportDataTable(DataTable datatable);
		Stream ExportExcel( string filterRules = "",string sort = "ID", string order = "asc");
	}
}