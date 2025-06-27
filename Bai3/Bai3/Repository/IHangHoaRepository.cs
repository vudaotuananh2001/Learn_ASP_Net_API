using Bai3.Models;

namespace Bai3.Repository
{
    public interface IHangHoaRepository
    {
        List<HangHoa> GetAll(string search);

        HangHoa Create(HangHoa hangHoa);
    }
}
