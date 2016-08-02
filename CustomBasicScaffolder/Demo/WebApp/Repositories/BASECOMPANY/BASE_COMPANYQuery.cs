
                    
      
     
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
   public class BASE_COMPANYQuery:QueryObject<BASE_COMPANY>
    {
        public BASE_COMPANYQuery WithAnySearch(string search)
        {
            if (!string.IsNullOrEmpty(search))
                And( x =>  x.ID.ToString().Contains(search) || x.CODE.Contains(search) || x.NAME.Contains(search) || x.REMARK.Contains(search) || x.ENABLED.ToString().Contains(search) || x.CREATEMAN.ToString().Contains(search) || x.STOPMAN.ToString().Contains(search) || x.STARTDATE.ToString().Contains(search) || x.ENDDATE.ToString().Contains(search) || x.CREATEDATE.ToString().Contains(search) || x.ENGLISHNAME.Contains(search) || x.DECLNATURE.Contains(search) || x.INSPCODE.Contains(search) || x.INCODE.Contains(search) || x.INSPNATURE.Contains(search) || x.GOODSLOCAL.Contains(search) || x.RECEIVERTYPE.Contains(search) || x.SOCIALCREDITNO.Contains(search) );
            return this;
        }

		public BASE_COMPANYQuery WithPopupSearch(string search,string para="")
        {
            if (!string.IsNullOrEmpty(search))
                And( x =>  x.ID.ToString().Contains(search) || x.CODE.Contains(search) || x.NAME.Contains(search) || x.REMARK.Contains(search) || x.ENABLED.ToString().Contains(search) || x.CREATEMAN.ToString().Contains(search) || x.STOPMAN.ToString().Contains(search) || x.STARTDATE.ToString().Contains(search) || x.ENDDATE.ToString().Contains(search) || x.CREATEDATE.ToString().Contains(search) || x.ENGLISHNAME.Contains(search) || x.DECLNATURE.Contains(search) || x.INSPCODE.Contains(search) || x.INCODE.Contains(search) || x.INSPNATURE.Contains(search) || x.GOODSLOCAL.Contains(search) || x.RECEIVERTYPE.Contains(search) || x.SOCIALCREDITNO.Contains(search) );
            return this;
        }

		public BASE_COMPANYQuery Withfilter(IEnumerable<filterRule> filters)
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
				    
					
				    				
											if (rule.field == "CODE"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.CODE.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "NAME"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.NAME.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "REMARK"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.REMARK.Contains(rule.value));
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
				   
				    				
					
				    
					
											if (rule.field == "CREATEDATE" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDateTime())
						{	
							var date = Convert.ToDateTime(rule.value) ;
							And(x => SqlFunctions.DateDiff("d", date, x.CREATEDATE)>=0);
						}
				   
				    				
											if (rule.field == "ENGLISHNAME"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.ENGLISHNAME.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "DECLNATURE"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.DECLNATURE.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "INSPCODE"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.INSPCODE.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "INCODE"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.INCODE.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "INSPNATURE"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.INSPNATURE.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "GOODSLOCAL"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.GOODSLOCAL.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "RECEIVERTYPE"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.RECEIVERTYPE.Contains(rule.value));
						}
				    
				    
					
					
				    				
											if (rule.field == "SOCIALCREDITNO"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.SOCIALCREDITNO.Contains(rule.value));
						}
				    
				    
					
					
				    									
                   
               }
           }
            return this;
        }
    }
}



