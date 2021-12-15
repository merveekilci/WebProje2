﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje2.Models.Siniflar;

namespace WebProje2.Controllers
{
    
    public class CariPanelController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {        
            var degerler = c.Mesajlars.Where(x => x.Alici == User.Identity.Name).ToList();
            var mailid = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();          
            var toplamsatis = c.SatisHarekets.Where(x => x.CarilerID == mailid).Count();
            ViewBag.d1 = toplamsatis;
            var toplamtutar = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.ToplamTutar);
            ViewBag.d2 = toplamtutar;
            var urunsayisi = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.Adet);
            ViewBag.d3 = urunsayisi;
            var adsoyad = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.d4 = adsoyad;
            var sehir = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariSehir).FirstOrDefault();
            ViewBag.d5 = sehir;
            return View(degerler);
        }
        [Authorize]
        public IActionResult Siparislerim()
        {
            var user = User.Identity.Name;
            var id = c.Carilers.Where(x => x.CariMail == user).Select(y => y.CarilerID).FirstOrDefault();
            var degerler = c.SatisHarekets
                .Include(x=>x.Urun)
                .Include(x=>x.Personel)
                .Where(x => x.CarilerID == id).ToList();
            return View(degerler);
        }
        [Authorize]
        public IActionResult GelenMesajlar()
        {
            var mail = User.Identity.Name;
            var mesajlar = c.Mesajlars.Where(x=>x.Alici==mail).OrderByDescending(x=>x.MesajlarID).ToList();
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View(mesajlar);
        }
        [Authorize]
        public IActionResult GidenMesajlar()
        {
            var mail = User.Identity.Name;
            var mesajlar = c.Mesajlars.Where(x => x.Gonderici == mail).OrderByDescending(x => x.MesajlarID).ToList();
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View(mesajlar);
        }
        [Authorize]
        [HttpGet]
        public IActionResult YeniMesaj()
        {
            var mail = User.Identity.Name;
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult YeniMesaj(Mesajlar d)
        {
            d.Gonderici = User.Identity.Name;
            d.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.Mesajlars.Add(d);
            c.SaveChanges();
            return View();
        }
        [Authorize]
        public IActionResult MesajDetay(int id)
        {
            var degerler = c.Mesajlars.Where(x => x.MesajlarID == id).ToList();
            var mail = User.Identity.Name;
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View(degerler);
        }
        [Authorize]
        public IActionResult KargoTakip(string search)
        {
            var k = from x in c.KargoDetays select x;
            k = k.Where(y => y.TakipKodu.Contains(search));
            return View(k.ToList());
        }
        [Authorize]
        public ActionResult KargoDetay(string id)
        {
            var degerler = c.KargoTakips.Where(x => x.TakipKodu == id).ToList();
            ViewBag.takipkodu = id;
            return View(degerler);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
        public IActionResult CariBilgilerim()
        {
            var mailid = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var toplamsatis = c.SatisHarekets.Where(x => x.CarilerID == mailid).Count();
            ViewBag.d1 = toplamsatis;
            var toplamtutar = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.ToplamTutar);
            ViewBag.d2 = toplamtutar;
            var urunsayisi = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.Adet);
            ViewBag.d3 = urunsayisi;
            var adsoyad = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.d4 = adsoyad;
            var sehir = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariSehir).FirstOrDefault();
            ViewBag.d5 = sehir;
            var id = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var caribul = c.Carilers.Find(id);
            return View("CariBilgilerim",caribul);
        }

        public IActionResult Duyurular()
        {
            var mailid = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var toplamsatis = c.SatisHarekets.Where(x => x.CarilerID == mailid).Count();
            ViewBag.d1 = toplamsatis;
            var toplamtutar = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.ToplamTutar);
            ViewBag.d2 = toplamtutar;
            var urunsayisi = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.Adet);
            ViewBag.d3 = urunsayisi;
            var adsoyad = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.d4 = adsoyad;
            var sehir = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariSehir).FirstOrDefault();
            ViewBag.d5 = sehir;
            var veriler = c.Mesajlars.Where(x => x.Gonderici == "admin").ToList();
            return View(veriler);
        }
        public IActionResult BilgilerimiGuncelle(Cariler cr)
        {
            var cari = c.Carilers.Find(cr.CarilerID);
            cari.CariAd = cr.CariAd;
            cari.CariSoyad = cr.CariSoyad;
            cari.Sifre = cr.Sifre;
            cari.CariSehir = cr.CariSehir;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}