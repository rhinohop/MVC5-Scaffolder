using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //wcfdataservice.OdpContext1 db = new wcfdataservice.OdpContext1(new Uri("http://localhost:12143/WcfDataService1.svc/"));
            //var item = db.BASE_CIQCODE.Where(x => x.CIQNAME == "6666").First();
            //item.CIQNAME = "更新";
            //db.UpdateObject(item);
            //db.SaveChanges(SaveChangesOptions.Batch);
            //db.DeleteObject(item);
            //db.SaveChanges();

            wcf2.StoreContext db = new wcf2.StoreContext(new Uri("http://localhost:12143/WcfDataService2.svc/"));
            var item = db.Products.First();
            item.Name = "ProductUpdate";
          
            db.UpdateObject(item);
            db.SaveChanges();
        }
    }
}
