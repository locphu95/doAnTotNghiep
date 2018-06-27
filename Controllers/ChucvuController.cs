using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NguyenPhuLoc.Models;


namespace NguyenPhuLoc.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ChucvuController : Controller
    {
        private AppDbContext _db;
        public ChucvuController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet("{mahk}/{manh}")]
        public IActionResult Get(string mahk, string manh)
        {
            var model = _db.HocKy.Where(x => x.MaNamHoc == manh && x.MaHocKy == mahk).ToList();
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var model =_db.ChucVu.ToList();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public IActionResult GetCb(string id)
        {
          try
          {
            ChucVu tour=_db.ChucVu.Find(id);
            return Ok(tour);
          }
          catch (Exception)
          {
            return BadRequest();
          }
        }
       [HttpGet("Detail/{id}")]
        public IActionResult GetDetail(string id)
        {
          try
          {
           var model =( from cv in _db.ChucVu 
           join ql in _db.ChiTietQuanLy on cv.MaChucVu equals ql.MaChucVu
           join cb in _db.CBNV on ql.MaCBNV equals cb.MaCBNV
           join dv in _db.DonVi on ql.MaDonVi equals dv.MaDonVi
           where cv.MaChucVu==id
            select new 
              { 
                cb.MaCBNV,cb.HoCBNV,cb.TenCBNV,cb.HocVi,cb.NTNS,dv.TenDonVi,cv.TenChucVu,cb.Phai,
                cb.DienThoai,cb.DiaChi

              });
            return Ok(model);
          }
          catch (Exception)
          {
            return BadRequest();
          }
        }



    }   
  
        
}
