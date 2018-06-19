using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NguyenPhuLoc.Models;


namespace NguyenPhuLoc.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class NamhocController : Controller
    {
        private AppDbContext _db;
        public NamhocController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet("{manv}")]
        public IActionResult Get(string manv)
        {
            var model = _db.NamHoc.Where(x => x.MaNamHoc == manv).ToList();
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var model = _db.NamHoc.ToList();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public IActionResult Getcv(string id)
        {
            try
            {
                NamHoc model = _db.NamHoc.Find(id);
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
