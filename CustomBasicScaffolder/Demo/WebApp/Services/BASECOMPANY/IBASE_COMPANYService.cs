

     
 
 

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

namespace WebApp.Services
{
    public interface IBASE_COMPANYService:IService<BASE_COMPANY>
    {



        void Enable(string companyCode);

		void ImportDataTable(DataTable datatable);
		Stream ExportExcel( string filterRules = "",string sort = "ID", string order = "asc");
	}
}