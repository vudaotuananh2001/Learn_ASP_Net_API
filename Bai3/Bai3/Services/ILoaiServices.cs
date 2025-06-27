using Bai3.Models;

namespace Bai3.Services
{
    public interface ILoaiServices
    {
        List<Loai> GetALl();
        Loai GetById(int id);
        Loai Create(Loai loai);
        void Update(Loai loai);
        void DeleteById(int id);
    }
}
