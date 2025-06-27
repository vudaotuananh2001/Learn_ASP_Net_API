using Bai3.Models;

namespace Bai3.Services
{
    public interface IHangHoaService
    {
        List<HangHoa> GetAll(string? search);

        HangHoa Create(HangHoa hangHoa);
    }
}
