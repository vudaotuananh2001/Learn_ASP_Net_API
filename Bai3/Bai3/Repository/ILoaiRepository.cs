using Bai3.Models;

namespace Bai3.Repository
{
    public interface ILoaiRepository
    {
        List<Loai> GetALl();
        Loai  GetById(int id);
        Loai Create(Loai loai);
        void Update(Loai loai);
        void DeleteById(int id);
    }
}
