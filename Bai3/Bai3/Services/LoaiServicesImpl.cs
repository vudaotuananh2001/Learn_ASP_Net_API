using Bai3.Models;
using Bai3.Repository;

namespace Bai3.Services
{
    public class LoaiServicesImpl : ILoaiServices
    {
        private readonly ILoaiRepository _loaiRepository;
        public  LoaiServicesImpl(ILoaiRepository loaiRepository)
        {
            _loaiRepository = loaiRepository;
        }
        public Loai Create(Loai loai)
        {
            var loaiCreate = _loaiRepository.Create(loai);
            return loaiCreate;
        }

        public void DeleteById(int id)
        {
            _loaiRepository.DeleteById(id);
        }

        public List<Loai> GetALl()
        {
            var list = _loaiRepository.GetALl();
            return list;
        }

        public Loai GetById(int id)
        {
            var getLoai = _loaiRepository.GetById(id);
            return getLoai;
        }

        public void Update(Loai loai)
        {
            _loaiRepository.Update(loai);
            
        }
    }
}
