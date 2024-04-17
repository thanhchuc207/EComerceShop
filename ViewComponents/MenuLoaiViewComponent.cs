using Ecomerce.Data;
using Ecomerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Ecomerce.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly EcomerceShopContext db;
        public MenuLoaiViewComponent(EcomerceShopContext context) => db = context;
        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVM
            {
                MaLoai =lo.MaLoai, TenLoai = lo.TenLoai, SoLuong = lo.HangHoas.Count
            }).OrderBy(p=>p.TenLoai);
            return View(data);
        }
    }
}
