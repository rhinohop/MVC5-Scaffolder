


using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repository.Pattern.UnitOfWork;
using Repository.Pattern.Infrastructure;
using WebApp.Models;
using WebApp.Services;
using WebApp.Repositories;
using WebApp.Extensions;


namespace WebApp.Controllers
{
    public class BASE_CIQCODEsController : Controller
    {
        
        //Please RegisterType UnityConfig.cs
        //container.RegisterType<IRepositoryAsync<BASE_CIQCODE>, Repository<BASE_CIQCODE>>();
        //container.RegisterType<IBASE_CIQCODEService, BASE_CIQCODEService>();
        
        //private StoreContext db = new StoreContext();
        private readonly IBASE_CIQCODEService  _bASE_CIQCODEService;
        private readonly IUnitOfWorkAsync _unitOfWork;

        public BASE_CIQCODEsController (IBASE_CIQCODEService  bASE_CIQCODEService, IUnitOfWorkAsync unitOfWork)
        {
            _bASE_CIQCODEService  = bASE_CIQCODEService;
            _unitOfWork = unitOfWork;
        }

        // GET: BASE_CIQCODEs/Index
        public ActionResult Index()
        {
            
            //var base_ciqcode  = _bASE_CIQCODEService.Queryable().AsQueryable();
            //return View(base_ciqcode  );
			return View();
        }

        // Get :BASE_CIQCODEs/PageList
        // For Index View Boostrap-Table load  data 
        [HttpGet]
        public ActionResult GetData(int page = 1, int rows = 10, string sort = "ID", string order = "asc", string filterRules = "")
        {
			var filters = JsonConvert.DeserializeObject<IEnumerable<filterRule>>(filterRules);
            int totalCount = 0;
            //int pagenum = offset / limit +1;
                        var base_ciqcode  = _bASE_CIQCODEService.Query(new BASE_CIQCODEQuery().Withfilter(filters)).OrderBy(n=>n.OrderBy(sort,order)).SelectPage(page, rows, out totalCount);
                        var datarows = base_ciqcode .Select(  n => new {  ID = n.ID , CIQ = n.CIQ , CIQNAME = n.CIQNAME , ENABLED = n.ENABLED , CREATEMAN = n.CREATEMAN , STOPMAN = n.STOPMAN , CREATEDATE = n.CREATEDATE , STARTDATE = n.STARTDATE , ENDDATE = n.ENDDATE , YEARID = n.YEARID , REMARK = n.REMARK }).ToList();
            var pagelist = new { total = totalCount, rows = datarows };
            return Json(pagelist, JsonRequestBehavior.AllowGet);
        }

		[HttpPost]
		public ActionResult SaveData(BASE_CIQCODEChangeViewModel base_ciqcode)
        {
            if (base_ciqcode.updated != null)
            {
                foreach (var updated in base_ciqcode.updated)
                {
                    _bASE_CIQCODEService.Update(updated);
                }
            }
            if (base_ciqcode.deleted != null)
            {
                foreach (var deleted in base_ciqcode.deleted)
                {
                    _bASE_CIQCODEService.Delete(deleted);
                }
            }
            if (base_ciqcode.inserted != null)
            {
                foreach (var inserted in base_ciqcode.inserted)
                {
                    _bASE_CIQCODEService.Insert(inserted);
                }
            }
            _unitOfWork.SaveChanges();

            return Json(new {Success=true}, JsonRequestBehavior.AllowGet);
        }

		
		
       
        // GET: BASE_CIQCODEs/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BASE_CIQCODE bASE_CIQCODE = _bASE_CIQCODEService.Find(id);
            if (bASE_CIQCODE == null)
            {
                return HttpNotFound();
            }
            return View(bASE_CIQCODE);
        }
        

        // GET: BASE_CIQCODEs/Create
        public ActionResult Create()
        {
            BASE_CIQCODE bASE_CIQCODE = new BASE_CIQCODE();
            //set default value
            return View(bASE_CIQCODE);
        }

        // POST: BASE_CIQCODEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CIQ,CIQNAME,ENABLED,CREATEMAN,STOPMAN,CREATEDATE,STARTDATE,ENDDATE,YEARID,REMARK")] BASE_CIQCODE bASE_CIQCODE)
        {
            if (ModelState.IsValid)
            {
             				_bASE_CIQCODEService.Insert(bASE_CIQCODE);
                           _unitOfWork.SaveChanges();
                if (Request.IsAjaxRequest())
                {
                    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                }
                DisplaySuccessMessage("Has append a BASE_CIQCODE record");
                return RedirectToAction("Index");
            }

            if (Request.IsAjaxRequest())
            {
                var modelStateErrors =String.Join("", this.ModelState.Keys.SelectMany(key => this.ModelState[key].Errors.Select(n=>n.ErrorMessage)));
                return Json(new { success = false, err = modelStateErrors }, JsonRequestBehavior.AllowGet);
            }
            DisplayErrorMessage();
            return View(bASE_CIQCODE);
        }

        // GET: BASE_CIQCODEs/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BASE_CIQCODE bASE_CIQCODE = _bASE_CIQCODEService.Find(id);
            if (bASE_CIQCODE == null)
            {
                return HttpNotFound();
            }
            return View(bASE_CIQCODE);
        }

        // POST: BASE_CIQCODEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CIQ,CIQNAME,ENABLED,CREATEMAN,STOPMAN,CREATEDATE,STARTDATE,ENDDATE,YEARID,REMARK")] BASE_CIQCODE bASE_CIQCODE)
        {
            if (ModelState.IsValid)
            {
                bASE_CIQCODE.ObjectState = ObjectState.Modified;
                				_bASE_CIQCODEService.Update(bASE_CIQCODE);
                                
                _unitOfWork.SaveChanges();
                if (Request.IsAjaxRequest())
                {
                    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                }
                DisplaySuccessMessage("Has update a BASE_CIQCODE record");
                return RedirectToAction("Index");
            }
            if (Request.IsAjaxRequest())
            {
                var modelStateErrors =String.Join("", this.ModelState.Keys.SelectMany(key => this.ModelState[key].Errors.Select(n=>n.ErrorMessage)));
                return Json(new { success = false, err = modelStateErrors }, JsonRequestBehavior.AllowGet);
            }
            DisplayErrorMessage();
            return View(bASE_CIQCODE);
        }

        // GET: BASE_CIQCODEs/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BASE_CIQCODE bASE_CIQCODE = _bASE_CIQCODEService.Find(id);
            if (bASE_CIQCODE == null)
            {
                return HttpNotFound();
            }
            return View(bASE_CIQCODE);
        }

        // POST: BASE_CIQCODEs/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BASE_CIQCODE bASE_CIQCODE =  _bASE_CIQCODEService.Find(id);
             _bASE_CIQCODEService.Delete(bASE_CIQCODE);
            _unitOfWork.SaveChanges();
           if (Request.IsAjaxRequest())
                {
                    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                }
            DisplaySuccessMessage("Has delete a BASE_CIQCODE record");
            return RedirectToAction("Index");
        }


       

 

		//导出Excel
		[HttpPost]
        public ActionResult ExportExcel( string filterRules = "",string sort = "Id", string order = "asc")
        {
            var fileName = "base_ciqcode_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            var stream=  _bASE_CIQCODEService.ExportExcel(filterRules,sort, order );
            return File(stream, "application/vnd.ms-excel", fileName);
      
        }
		


        private void DisplaySuccessMessage(string msgText)
        {
            TempData["SuccessMessage"] = msgText;
        }

        private void DisplayErrorMessage()
        {
            TempData["ErrorMessage"] = "Save changes was unsuccessful.";
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _unitOfWork.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
