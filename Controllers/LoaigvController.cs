using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NguyenPhuLoc.Models;


namespace NguyenPhuLoc.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class LoaigvController : Controller
    {
        private AppDbContext _db;
        public LoaigvController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet("{manv}")]
        public IActionResult Get(string manv)
        {
            var model = _db.LoaiGiangVien.Where(x => x.MaLoaiGiangVien == manv).ToList();
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var model = _db.LoaiGiangVien.ToList();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public IActionResult Getcv(string id)
        {
            try
            {
                LoaiGiangVien model = _db.LoaiGiangVien.Find(id);
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
                var model = (from cb in _db.CBNV
                             from l in _db.LoaiGiangVien
                             where cb.MaLoaiGiangVien == l.MaLoaiGiangVien
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
