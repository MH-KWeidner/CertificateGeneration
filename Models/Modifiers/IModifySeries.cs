using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models.Modifiers
{
    public interface IModifySeries
    {
        public List<SeriesValue> Modify(List<SeriesValue> seriesValues);
    }
}
