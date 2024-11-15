using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataQueries
{
    public class QueryZeroForceItems : IQuerySeries
    {
        public List<SeriesValue> Query(List<SeriesValue>? seriesValues)
        {
            ArgumentNullException.ThrowIfNull(seriesValues);

            return seriesValues.Where(sv => sv.AppliedForce == 0).ToList();
        }
    }
}
