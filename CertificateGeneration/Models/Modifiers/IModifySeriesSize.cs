using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CertificateGeneration.Models.Modifiers;

namespace CertificateGeneration.Models.Modifiers
{
    public interface IModifySeriesSize
    {
        public List<SeriesValue>? Modify(List<SeriesValue>? seriesValues);
    }
}
