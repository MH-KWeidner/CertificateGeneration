using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.Models.DataQueries
{
    public interface IQuerySeries
    {
        public List<SeriesValue> Query(List<SeriesValue>? seriesValues);
    }
}
