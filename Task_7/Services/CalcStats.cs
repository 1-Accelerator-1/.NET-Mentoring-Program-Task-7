using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_7.Services.Interfaces;

namespace Task_7.Services
{
    internal class CalcStats : ICalcStats
    {
        private int _maxNumber;
        private int _minNumber;
        private int _numberOfElements;
        private double _average;

        public int MaxNumber => _maxNumber;

        public int MinNumber => _minNumber;

        public int NumberOfElements => _numberOfElements;

        public double Average => _average;

        public async Task CalcCollectionStats(IEnumerable<int> collection)
        {
            _maxNumber = await Task.Run(() => collection.Max());
            _minNumber = await Task.Run(() => collection.Min());
            _numberOfElements = await Task.Run(() => collection.Count());
            _average = await Task.Run(() => collection.Average());
        }
    }
}
