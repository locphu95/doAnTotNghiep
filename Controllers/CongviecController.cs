using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NguyenPhuLoc.Models;


namespace NguyenPhuLoc.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CongviecController : Controller
    {
        private AppDbContext _db;
        public CongviecController(AppDbContext db)
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
            var model =_db.CongViec.ToList();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public IActionResult Getcv(string id)
        {
          try
          {
            CongViec model=_db.CongViec.Find(id);
            return Ok(model);
          }
          catch (Exception)
          {
            return BadRequest();
          }
        }
       [HttpGet("Detail/{id}")]
        public IActionResult GetDetail(int id)
        {
          try
          {
           var model =(from cb in _db.CBNV
                from l in _db.LoaiGiangVien
                where cb.MaLoaiGiangVien ==l.MaLoaiGiangVien
            select new 
              { 
                l.TenLoaiGiangVien,

              }).ToList();
            return Ok(model);
          }
          catch (Exception)
          {
            return BadRequest();
          }
        }



    }   
  
        
}
