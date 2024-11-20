using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.Models.Modifiers
{
    public interface IOrderSeries
    {
        public List<SeriesValue>? Order(List<SeriesValue>? seriesValues);
    }
}
