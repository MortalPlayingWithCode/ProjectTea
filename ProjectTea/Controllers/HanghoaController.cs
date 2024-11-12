using Microsoft.AspNetCore.Mvc;
using ProjectTea.Data;
using ProjectTea.ViewModels;

namespace ProjectTea.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly TeaContext db;
        public HangHoaController(TeaContext context) {
            db = context;
        }
        public IActionResult Index (int? Loai)
        {
            var HangHoas = db.HangHoas.AsQueryable();
            if (Loai.HasValue)
            {
                HangHoas = HangHoas.Where(p => p.MaLoai == Loai.Value);
            }
            var result = HangHoas.Select(p => new HanghoaVm
            {
                MaHh = p.MaHh,  
                TenHH = p.TenHh,
                Hinh  = p.Hinh ?? "",
                MoTaNgan = p.MoTaDonVi ?? "",
                TenLoai = p.MaLoaiNavigation.TenLoai
            });
            return View(result);
        }
    }
}
