using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_7.Services.Interfaces
{
    public interface ICalcStats
    {
        int MaxNumber { get; }

        int MinNumber { get; }

        int NumberOfElements { get; }

        int Average { get; }

        Task CalcCollectionStats(IEnumerable<int> collection);
    }
}
