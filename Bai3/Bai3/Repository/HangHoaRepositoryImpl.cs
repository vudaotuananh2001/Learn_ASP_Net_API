using Bai3.Data;
using Bai3.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai3.Repository
{
    public class HangHoaRepositoryImpl : IHangHoaRepository
    {
        private readonly MyDBContext _context;
        public HangHoaRepositoryImpl(MyDBContext context)
        {
            _context = context;
        }

        public HangHoa Create(HangHoa hangHoa)
        {
            var hangHoaCreate = new HangHoa
            {
                TenHH = hangHoa.TenHH,
                MoTa = hangHoa.MoTa,
                DonGia = hangHoa.DonGia,
                GiamGia = hangHoa.GiamGia,
                MaLoai = hangHoa.MaLoai
            };
            _context.Add(hangHoaCreate);
            _context.SaveChanges();
            return new HangHoa
            {
                TenHH = hangHoa.TenHH,
                MoTa = hangHoa.MoTa,
                DonGia = hangHoa.DonGia,
                GiamGia = hangHoa.GiamGia,
                MaLoai = hangHoa.MaLoai
            };
        }

        public List<HangHoa> GetAll(string? search)
        {
            if (string.IsNullOrWhiteSpace(search))
            {
                return _context.hangHoas
                    .Include(hh => hh.Loai) 
                    .ToList();
            }

            return _context.hangHoas
                .Include(hh => hh.Loai)
                .Where(x => x.TenHH.Contains(search))
                .ToList();
        }
    }
}
