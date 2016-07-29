
             
           
 




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
using System.Reflection;

using Newtonsoft.Json;
using WebApp.Extensions;
using System.IO;

namespace WebApp.Services
{
    public class BASE_CIQCODEService : Service< BASE_CIQCODE >, IBASE_CIQCODEService
    {

        private readonly IRepositoryAsync<BASE_CIQCODE> _repository;
		 private readonly IDataTableImportMappingService _mappingservice;
        public  BASE_CIQCODEService(IRepositoryAsync< BASE_CIQCODE> repository,IDataTableImportMappingService mappingservice)
            : base(repository)
        {
            _repository=repository;
			_mappingservice = mappingservice;
        }
        
                  
        

		public void ImportDataTable(System.Data.DataTable datatable)
        {
            foreach (DataRow row in datatable.Rows)
            {
                 
                BASE_CIQCODE item = new BASE_CIQCODE();
				var mapping = _mappingservice.Queryable().Where(x => x.EntitySetName == "BASE_CIQCODE").ToList();

                foreach (var field in mapping)
                {
                 
						var defval = field.DefaultValue;
						var contation = datatable.Columns.Contains((field.SourceFieldName == null ? "" : field.SourceFieldName));
						if (contation && row[field.SourceFieldName] != DBNull.Value)
						{
							Type base_ciqcodetype = item.GetType();
							PropertyInfo propertyInfo = base_ciqcodetype.GetProperty(field.FieldName);
							propertyInfo.SetValue(item, Convert.ChangeType(row[field.SourceFieldName], propertyInfo.PropertyType), null);
						}
						else if (!string.IsNullOrEmpty(defval))
						{
							Type base_ciqcodetype = item.GetType();
							PropertyInfo propertyInfo = base_ciqcodetype.GetProperty(field.FieldName);
							if (defval.ToLower() == "now" && propertyInfo.PropertyType ==typeof(DateTime))
                            {
                                propertyInfo.SetValue(item, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                            }
                            else
                            {
                                propertyInfo.SetValue(item, Convert.ChangeType(defval, propertyInfo.PropertyType), null);
                            }
						}
                }
                
                this.Insert(item);
               

            }
        }
		
		public Stream ExportExcel(string filterRules = "",string sort = "ID", string order = "asc")
        {
            var filters = JsonConvert.DeserializeObject<IEnumerable<filterRule>>(filterRules);
                                   var base_ciqcode  = this.Query(new BASE_CIQCODEQuery().Withfilter(filters)).OrderBy(n=>n.OrderBy(sort,order)).Select().ToList();
                        var datarows = base_ciqcode .Select(  n => new {  ID = n.ID , CIQ = n.CIQ , CIQNAME = n.CIQNAME , ENABLED = n.ENABLED , CREATEMAN = n.CREATEMAN , STOPMAN = n.STOPMAN , CREATEDATE = n.CREATEDATE , STARTDATE = n.STARTDATE , ENDDATE = n.ENDDATE , YEARID = n.YEARID , REMARK = n.REMARK }).ToList();
           
            return ExcelHelper.ExportExcel(typeof(BASE_CIQCODE), datarows);

        }

        public IEnumerable<BASE_CIQCODE> Get()
        {
            return this._repository.Queryable();
        }
    }
}



