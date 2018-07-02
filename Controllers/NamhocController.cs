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
        [HttpGet]
        public IActionResult Get()
        {
            var model =from a in  _db.NamHoc where a.TrangThai==true select a;
            return Ok(model);
        }
        [HttpGet("Detail/{id}")]
        public IActionResult GetDetail(string id)
        {
            try
            {
                var model = (from nh in _db.NamHoc 
                             join hk in _db.HocKy on nh.MaNamHoc equals hk.MaNamHoc
                             where nh.MaNamHoc==id
                             select new
                             {
                                nh.MaNamHoc,nh.NgayBatDauNamHoc,nh.NgayKetThucNamHoc,nh.MoTaNamHoc,hk

                             }).ToList();
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        public IActionResult Post([FromBody] NamHoc cb)
        {
          cb.TrangThai=true;
          try
          {
            NamHoc tour=new NamHoc(){
                MaNamHoc=cb.MaNamHoc,
                NgayBatDauNamHoc=cb.NgayBatDauNamHoc,
                NgayKetThucNamHoc= cb.NgayKetThucNamHoc,
                MoTaNamHoc=cb.MoTaNamHoc,
                TrangThai=cb.TrangThai
            };
            _db.NamHoc.Add(tour);
            _db.SaveChanges();
            return Ok("Them thanh cong");
          }
          catch (Exception)
          {
            return BadRequest();
          }
        }
     [HttpGet("Delete/{id}")]
         public IActionResult Post3(string id)
        {
          try{
            NamHoc del =_db.NamHoc.FirstOrDefault(x=>x.MaNamHoc==id);
             del.TrangThai = false;
            _db.SaveChanges();
            return Ok("Xoa thanh cong");
          }
          catch{
             return BadRequest();
          }
        }


    }


}
