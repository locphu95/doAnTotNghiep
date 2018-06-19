using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NguyenPhuLoc.Models;


namespace NguyenPhuLoc.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class QuydinhController : Controller
    {
        private AppDbContext _db;
        public QuydinhController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet("{ma}")]
        public IActionResult Get(string ma)
        {
            var model = _db.QuyDinh.Where(x => x.SoQuyDinh == ma).ToList();
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var model = _db.QuyDinh.ToList();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public IActionResult Getcv(string id)
        {
            try
            {
                QuyDinh model = _db.QuyDinh.Find(id);
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
