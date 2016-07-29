
                    
      
     
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity.SqlServer;
using Repository.Pattern.Repositories;
using Repository.Pattern.Ef6;
using System.Web.WebPages;
using WebApp.Models;
using WebApp.Extensions;

namespace WebApp.Repositories
{
   public class BASE_CIQCODEQuery:QueryObject<BASE_CIQCODE>
    {
        public BASE_CIQCODEQuery WithAnySearch(string search)
        {
            if (!string.IsNullOrEmpty(search))
                And( x =>  x.ID.ToString().Contains(search) || x.CIQ.Contains(search) || x.CIQNAME.Contains(search) || x.ENABLED.ToString().Contains(search) || x.CREATEMAN.ToString().Contains(search) || x.STOPMAN.ToString().Contains(search) || x.CREATEDATE.ToString().Contains(search) || x.STARTDATE.ToString().Contains(search) || x.ENDDATE.ToString().Contains(search) || x.YEARID.ToString().Contains(search) || x.REMARK.Contains(search) );
            return this;
        }

		public BASE_CIQCODEQuery WithPopupSearch(string search,string para="")
        {
            if (!string.IsNullOrEmpty(search))
                And( x =>  x.ID.ToString().Contains(search) || x.CIQ.Contains(search) || x.CIQNAME.Contains(search) || x.ENABLED.ToString().Contains(search) || x.CREATEMAN.ToString().Contains(search) || x.STOPMAN.ToString().Contains(search) || x.CREATEDATE.ToString().Contains(search) || x.STARTDATE.ToString().Contains(search) || x.ENDDATE.ToString().Contains(search) || x.YEARID.ToString().Contains(search) || x.REMARK.Contains(search) );
            return this;
        }

		public BASE_CIQCODEQuery Withfilter(IEnumerable<filterRule> filters)
        {
           if (filters != null)
           {
               foreach (var rule in filters)
               {
                  
					
				    
											if (rule.field == "ID" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							And(x => x.ID == val);
						}
				    
					
				    				
											if (rule.field == "CIQ"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.CIQ.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "CIQNAME"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.CIQNAME.Contains(rule.value));
						}
				    
				    
					
					
				    				
					
				    
											if (rule.field == "ENABLED" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							And(x => x.ENABLED == val);
						}
				    
					
				    				
					
				    
											if (rule.field == "CREATEMAN" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							And(x => x.CREATEMAN == val);
						}
				    
					
				    				
					
				    
											if (rule.field == "STOPMAN" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							And(x => x.STOPMAN == val);
						}
				    
					
				    				
					
				    
					
											if (rule.field == "CREATEDATE" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDateTime())
						{	
							var date = Convert.ToDateTime(rule.value) ;
							And(x => SqlFunctions.DateDiff("d", date, x.CREATEDATE)>=0);
						}
				   
				    				
					
				    
					
											if (rule.field == "STARTDATE" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDateTime())
						{	
							var date = Convert.ToDateTime(rule.value) ;
							And(x => SqlFunctions.DateDiff("d", date, x.STARTDATE)>=0);
						}
				   
				    				
					
				    
					
											if (rule.field == "ENDDATE" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDateTime())
						{	
							var date = Convert.ToDateTime(rule.value) ;
							And(x => SqlFunctions.DateDiff("d", date, x.ENDDATE)>=0);
						}
				   
				    				
					
				    
											if (rule.field == "YEARID" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							And(x => x.YEARID == val);
						}
				    
					
				    				
											if (rule.field == "REMARK"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.REMARK.Contains(rule.value));
						}
				    
				    
					
					
				    									
                   
               }
           }
            return this;
        }
    }
}



