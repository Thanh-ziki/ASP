using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL._1.Models;

namespace PTPMQL._1.Controllers
{
    public class KhachHangController : Controller
    {
        //Khai báo đối tượng kết nối tới database
        DemoDbContext db = new DemoDbContext();
        // GET: KhachHang
        public ViewResult Index()
        {
            //lay toan bo du lieu trong bang KhachHang
            //tra ve dang list roi hien thị len view
            return View(db.KhachHangs.ToList());
        }
        //tao action create tra ve view cho ngươi dung
        //nhạp thong tin khách hàng de them mới vào CSDL
        public ActionResult Create()
        {
            return View();
        }
        //tao action create voi tham so de nhan du lieuj clidet
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KhachHang kh)
        {
            // neu dieu kien rang buoc o class duoc thoa man
            if(ModelState.IsValid)
            {
                //them moi doi tuong kh vao trong CSDL
                db.KhachHangs.Add(kh);
                //cap nhap thay doi vào CSDL
                db.SaveChanges();
                return RedirectToAction("Index");
            }   
            //neu dieu kien rang buoc o class khong thỏa man
            return View(kh);
        }
    }
  
}