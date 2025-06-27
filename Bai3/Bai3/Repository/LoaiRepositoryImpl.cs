using Bai3.Data;
using Bai3.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai3.Repository
{
    public class LoaiRepositoryImpl : ILoaiRepository
    {
        private readonly MyDBContext _context;
        public LoaiRepositoryImpl(MyDBContext context)
        {
            _context = context;
        }
        public Loai Create(Loai loai)
        {
            var loaiCreate = new Loai
            {
                TenLoai = loai.TenLoai
            };
            _context.Add(loaiCreate);
            _context.SaveChanges();
            return new Loai
            {
                MaLoai  = loaiCreate.MaLoai,
                TenLoai = loaiCreate.TenLoai
            };
        }

        public void DeleteById(int id)
        {
            var loai = _context.Loais.SingleOrDefault(lo => lo.MaLoai == id);
            if(loai!= null)
            {
                _context.Remove(loai);
                _context.SaveChanges();
            }
        }

        public List<Loai> GetALl()
        {
            var list = _context.Loais.Select(loai => new Loai
            {
                MaLoai = loai.MaLoai,
                TenLoai = loai.TenLoai
            }).ToList();
            return list;
        }

        public Loai GetById(int id)
        {
            var loai = _context.Loais.SingleOrDefault(lo => lo.MaLoai == id);
            if (loai != null)
            {
                return new Loai
                {
                    MaLoai = loai.MaLoai,
                    TenLoai  =loai.TenLoai
                };
            }
            return null;
        }

        public void Update(Loai loai)
        {
            var loaiUpdate = _context.Loais.SingleOrDefault(lo => lo.MaLoai == loai.MaLoai);
            loaiUpdate.TenLoai = loai.TenLoai;
            _context.SaveChanges();
        }
    }
}
