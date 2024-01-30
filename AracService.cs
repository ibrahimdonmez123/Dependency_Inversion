using Dependency_Inversion.Models;

namespace Dependency_Inversion
{
    public class AracService : IAracService
    {
        public List<Arac> GetAracListesi()
        {
            return new List<Arac>
        {
            new Arac { Marka = "Audi", Model = "A3", Yil = 2022 },
            new Arac { Marka = "BMW", Model = "X5", Yil = 2021 },
            new Arac { Marka = "Mercedes", Model = "C200", Yil = 2023 }
        };
        }
    }
}
