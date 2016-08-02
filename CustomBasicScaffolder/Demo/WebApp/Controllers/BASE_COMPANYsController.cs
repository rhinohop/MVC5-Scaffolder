


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
    public class BASE_COMPANYsController : Controller
    {
        
        //Please RegisterType UnityConfig.cs
        //container.RegisterType<IRepositoryAsync<BASE_COMPANY>, Repository<BASE_COMPANY>>();
        //container.RegisterType<IBASE_COMPANYService, BASE_COMPANYService>();
        
        //private StoreContext db = new StoreContext();
        private readonly IBASE_COMPANYService  _bASE_COMPANYService;
        private readonly IUnitOfWorkAsync _unitOfWork;

        public BASE_COMPANYsController (IBASE_COMPANYService  bASE_COMPANYService, IUnitOfWorkAsync unitOfWork)
        {
            _bASE_COMPANYService  = bASE_COMPANYService;
            _unitOfWork = unitOfWork;
        }

        // GET: BASE_COMPANYs/Index
        public ActionResult Index()
        {
            
            //var base_company  = _bASE_COMPANYService.Queryable().AsQueryable();
            //return View(base_company  );
			return View();
        }

        // Get :BASE_COMPANYs/PageList
        // For Index View Boostrap-Table load  data 
        [HttpGet]
        public ActionResult GetData(int page = 1, int rows = 10, string sort = "ID", string order = "asc", string filterRules = "")
        {
			var filters = JsonConvert.DeserializeObject<IEnumerable<filterRule>>(filterRules);
            int totalCount = 0;
            //int pagenum = offset / limit +1;
                        var base_company  = _bASE_COMPANYService.Query(new BASE_COMPANYQuery().Withfilter(filters)).OrderBy(n=>n.OrderBy(sort,order)).SelectPage(page, rows, out totalCount);
                        var datarows = base_company .Select(  n => new {  ID = n.ID , CODE = n.CODE , NAME = n.NAME , REMARK = n.REMARK , ENABLED = n.ENABLED , CREATEMAN = n.CREATEMAN , STOPMAN = n.STOPMAN , STARTDATE = n.STARTDATE , ENDDATE = n.ENDDATE , CREATEDATE = n.CREATEDATE , ENGLISHNAME = n.ENGLISHNAME , DECLNATURE = n.DECLNATURE , INSPCODE = n.INSPCODE , INCODE = n.INCODE , INSPNATURE = n.INSPNATURE , GOODSLOCAL = n.GOODSLOCAL , RECEIVERTYPE = n.RECEIVERTYPE , SOCIALCREDITNO = n.SOCIALCREDITNO }).ToList();
            var pagelist = new { total = totalCount, rows = datarows };
            return Json(pagelist, JsonRequestBehavior.AllowGet);
        }

		[HttpPost]
		public ActionResult SaveData(BASE_COMPANYChangeViewModel base_company)
        {
            if (base_company.updated != null)
            {
                foreach (var updated in base_company.updated)
                {
                    _bASE_COMPANYService.Update(updated);
                }
            }
            if (base_company.deleted != null)
            {
                foreach (var deleted in base_company.deleted)
                {
                    _bASE_COMPANYService.Delete(deleted);
                }
            }
            if (base_company.inserted != null)
            {
                foreach (var inserted in base_company.inserted)
                {
                    _bASE_COMPANYService.Insert(inserted);
                }
            }
            _unitOfWork.SaveChanges();

            return Json(new {Success=true}, JsonRequestBehavior.AllowGet);
        }

		
		
       
        // GET: BASE_COMPANYs/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BASE_COMPANY bASE_COMPANY = _bASE_COMPANYService.Find(id);
            if (bASE_COMPANY == null)
            {
                return HttpNotFound();
            }
            return View(bASE_COMPANY);
        }
        

        // GET: BASE_COMPANYs/Create
        public ActionResult Create()
        {
            BASE_COMPANY bASE_COMPANY = new BASE_COMPANY();
            //set default value
            return View(bASE_COMPANY);
        }

        // POST: BASE_COMPANYs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CODE,NAME,REMARK,ENABLED,CREATEMAN,STOPMAN,STARTDATE,ENDDATE,CREATEDATE,ENGLISHNAME,DECLNATURE,INSPCODE,INCODE,INSPNATURE,GOODSLOCAL,RECEIVERTYPE,SOCIALCREDITNO")] BASE_COMPANY bASE_COMPANY)
        {
            if (ModelState.IsValid)
            {
             				_bASE_COMPANYService.Insert(bASE_COMPANY);
                           _unitOfWork.SaveChanges();
                if (Request.IsAjaxRequest())
                {
                    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                }
                DisplaySuccessMessage("Has append a BASE_COMPANY record");
                return RedirectToAction("Index");
            }

            if (Request.IsAjaxRequest())
            {
                var modelStateErrors =String.Join("", this.ModelState.Keys.SelectMany(key => this.ModelState[key].Errors.Select(n=>n.ErrorMessage)));
                return Json(new { success = false, err = modelStateErrors }, JsonRequestBehavior.AllowGet);
            }
            DisplayErrorMessage();
            return View(bASE_COMPANY);
        }

        // GET: BASE_COMPANYs/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BASE_COMPANY bASE_COMPANY = _bASE_COMPANYService.Find(id);
            if (bASE_COMPANY == null)
            {
                return HttpNotFound();
            }
            return View(bASE_COMPANY);
        }

        // POST: BASE_COMPANYs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CODE,NAME,REMARK,ENABLED,CREATEMAN,STOPMAN,STARTDATE,ENDDATE,CREATEDATE,ENGLISHNAME,DECLNATURE,INSPCODE,INCODE,INSPNATURE,GOODSLOCAL,RECEIVERTYPE,SOCIALCREDITNO")] BASE_COMPANY bASE_COMPANY)
        {
            if (ModelState.IsValid)
            {
                bASE_COMPANY.ObjectState = ObjectState.Modified;
                				_bASE_COMPANYService.Update(bASE_COMPANY);
                                
                _unitOfWork.SaveChanges();
                if (Request.IsAjaxRequest())
                {
                    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                }
                DisplaySuccessMessage("Has update a BASE_COMPANY record");
                return RedirectToAction("Index");
            }
            if (Request.IsAjaxRequest())
            {
                var modelStateErrors =String.Join("", this.ModelState.Keys.SelectMany(key => this.ModelState[key].Errors.Select(n=>n.ErrorMessage)));
                return Json(new { success = false, err = modelStateErrors }, JsonRequestBehavior.AllowGet);
            }
            DisplayErrorMessage();
            return View(bASE_COMPANY);
        }

        // GET: BASE_COMPANYs/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BASE_COMPANY bASE_COMPANY = _bASE_COMPANYService.Find(id);
            if (bASE_COMPANY == null)
            {
                return HttpNotFound();
            }
            return View(bASE_COMPANY);
        }

        // POST: BASE_COMPANYs/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BASE_COMPANY bASE_COMPANY =  _bASE_COMPANYService.Find(id);
             _bASE_COMPANYService.Delete(bASE_COMPANY);
            _unitOfWork.SaveChanges();
           if (Request.IsAjaxRequest())
                {
                    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                }
            DisplaySuccessMessage("Has delete a BASE_COMPANY record");
            return RedirectToAction("Index");
        }


       

 

		//导出Excel
		[HttpPost]
        public ActionResult ExportExcel( string filterRules = "",string sort = "Id", string order = "asc")
        {
            var fileName = "base_company_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            var stream=  _bASE_COMPANYService.ExportExcel(filterRules,sort, order );
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
