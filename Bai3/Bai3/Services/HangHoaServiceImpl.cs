using Bai3.Models;
using Bai3.Repository;

namespace Bai3.Services
{
    public class HangHoaServiceImpl : IHangHoaService
    {
        private readonly IHangHoaRepository _hangHoaRepository;
        public HangHoaServiceImpl(IHangHoaRepository hangHoaRepository)
        {
            _hangHoaRepository = hangHoaRepository;
        }
        public HangHoa Create(HangHoa hangHoa)
        {
            var hangHoaCreate = _hangHoaRepository.Create(hangHoa);
            return hangHoaCreate;
        }

        public List<HangHoa> GetAll(string? search)
        {
            var list = _hangHoaRepository.GetAll(search).ToList();
            return list;
        }
    }
}
