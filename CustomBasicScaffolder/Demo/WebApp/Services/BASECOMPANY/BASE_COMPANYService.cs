
             
           
 




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
    public class BASE_COMPANYService : Service< BASE_COMPANY >, IBASE_COMPANYService
    {

        private readonly IRepositoryAsync<BASE_COMPANY> _repository;
		 private readonly IDataTableImportMappingService _mappingservice;
        public  BASE_COMPANYService(IRepositoryAsync< BASE_COMPANY> repository,IDataTableImportMappingService mappingservice)
            : base(repository)
        {
            _repository=repository;
			_mappingservice = mappingservice;
        }
        
                  
        

		public void ImportDataTable(System.Data.DataTable datatable)
        {
            foreach (DataRow row in datatable.Rows)
            {
                 
                BASE_COMPANY item = new BASE_COMPANY();
				var mapping = _mappingservice.Queryable().Where(x => x.EntitySetName == "BASE_COMPANY").ToList();

                foreach (var field in mapping)
                {
                 
						var defval = field.DefaultValue;
						var contation = datatable.Columns.Contains((field.SourceFieldName == null ? "" : field.SourceFieldName));
						if (contation && row[field.SourceFieldName] != DBNull.Value)
						{
							Type base_companytype = item.GetType();
							PropertyInfo propertyInfo = base_companytype.GetProperty(field.FieldName);
							propertyInfo.SetValue(item, Convert.ChangeType(row[field.SourceFieldName], propertyInfo.PropertyType), null);
						}
						else if (!string.IsNullOrEmpty(defval))
						{
							Type base_companytype = item.GetType();
							PropertyInfo propertyInfo = base_companytype.GetProperty(field.FieldName);
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
                                   var base_company  = this.Query(new BASE_COMPANYQuery().Withfilter(filters)).OrderBy(n=>n.OrderBy(sort,order)).Select().ToList();
                        var datarows = base_company .Select(  n => new {  ID = n.ID , CODE = n.CODE , NAME = n.NAME , REMARK = n.REMARK , ENABLED = n.ENABLED , CREATEMAN = n.CREATEMAN , STOPMAN = n.STOPMAN , STARTDATE = n.STARTDATE , ENDDATE = n.ENDDATE , CREATEDATE = n.CREATEDATE , ENGLISHNAME = n.ENGLISHNAME , DECLNATURE = n.DECLNATURE , INSPCODE = n.INSPCODE , INCODE = n.INCODE , INSPNATURE = n.INSPNATURE , GOODSLOCAL = n.GOODSLOCAL , RECEIVERTYPE = n.RECEIVERTYPE , SOCIALCREDITNO = n.SOCIALCREDITNO }).ToList();
           
            return ExcelHelper.ExportExcel(typeof(BASE_COMPANY), datarows);

        }

        public void Enable(string companyCode)
        {
            throw new NotImplementedException();
        }
    }
}



