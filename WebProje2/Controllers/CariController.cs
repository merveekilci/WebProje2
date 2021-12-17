using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProje2.Models.Siniflar;
namespace WebProje2.Controllers
{
    [Authorize(Roles = "A,B")]
    public class CariController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var deger = c.Carilers.Where(x => x.Durum == true).ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniCari()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniCari(Cariler p)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniCari");
            }
            p.Durum = true;
            c.Carilers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CariSil(int id)
        {
            var cari = c.Carilers.Find(id);
            cari.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CariGetir(int id)
        {
            var cari = c.Carilers.Find(id);
            return View("CariGetir", cari);
        }
        public ActionResult CariGuncelle(Cariler p)
        {
            if (!ModelState.IsValid)
            {
                return View("CariGetir");
            }
            var cari = c.Carilers.Find(p.CarilerID);
            cari.CariAd = p.CariAd;
            cari.CariSoyad = p.CariSoyad;
            cari.CariSehir = p.CariSehir;
            cari.CariMail = p.CariMail;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult MusteriSatis(int id)
        {
            //var degerler = c.SatisHarekets.Where(x => x.Cariid == id).ToList(); 
            var degerler = c.SatisHarekets
                .Include(x=>x.Urun)
                .Include(x => x.Personel)
                .Where(x => x.CarilerID == id).ToList();
            var ilgiliMusteri = c.Carilers.Where(x => x.CarilerID == id).Select(y => y.CariAd+ " "+y.CariSoyad).FirstOrDefault();
            ViewBag.musteri = ilgiliMusteri;
            return View("MusteriSatis",degerler);
        }
    }
}