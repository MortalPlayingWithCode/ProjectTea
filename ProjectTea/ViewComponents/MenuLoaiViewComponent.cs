using Microsoft.AspNetCore.Mvc;
using ProjectTea.Data;
using ProjectTea.ViewModels;

namespace ProjectTea.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly TeaContext db;
        public MenuLoaiViewComponent(TeaContext context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVm
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            }).OrderBy(p => p.TenLoai);

            return View(data); // Defaul.cshtml
        }
    }
}   
    