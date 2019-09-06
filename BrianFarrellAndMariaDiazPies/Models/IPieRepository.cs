using System.Collections.Generic;

namespace BrianFarrellAndMariaDiazPies.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);


    }
}
