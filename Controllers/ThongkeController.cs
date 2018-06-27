using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NguyenPhuLoc.Models;


namespace NguyenPhuLoc.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ThongkeController : Controller
    {
        private AppDbContext _db;
        public ThongkeController(AppDbContext db)
        {
            _db = db;
        }
       [HttpGet("{id}")]
        public IActionResult Getcv(string id)
        {
          try
          {
           var model = (from cb in _db.CBNV
                join l in _db.PhieuDangKy
                on cb.MaCBNV equals l.MaCBNV
                join ct in _db.ChiTietDangKy
                on l.MaPhieuDangKy equals ct.MaPhieuDangKy
                join cv in _db.CongViec
                on ct.MaCongViec equals cv.MaCongViec
                where cb.MaCBNV==id
            select new 
              {
                  l.MaPhieuDangKy,l.NgayDangKy,cv.TenCongViec
              });

         // var model = _db.CBNV.ToList();
            return Ok(model);
          }
          catch (Exception)
          {
            return BadRequest();
          }
        }
        [HttpGet("Khoa/{id}")]
        public IActionResult Getkhoacv(string id)
        {
          try
          {
           var model = (from dv in _db.DonVi
                join ctql in _db.ChiTietQuanLy
                on dv.MaDonVi equals ctql.MaDonVi
                join cb in _db.CBNV
                on ctql.MaCBNV equals cb.MaCBNV
                join pdk in _db.PhieuDangKy
                on cb.MaCBNV equals pdk.MaCBNV
                join ctdk in _db.ChiTietDangKy
                on pdk.MaPhieuDangKy equals ctdk.MaPhieuDangKy
                join cv in _db.CongViec
                on ctdk.MaCongViec equals cv.MaCongViec
                where dv.MaDonVi==id
            select new 
              {
                 cb.MaCBNV, cb.HoCBNV,cb.TenCBNV,pdk.MaPhieuDangKy,cv.TenCongViec
              });

         // var model = _db.CBNV.ToList();
            return Ok(model);
          }
          catch (Exception)
          {
            return BadRequest();
          }
        }
      
  }
}
