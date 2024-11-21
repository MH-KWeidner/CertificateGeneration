using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.Models.TestModifiers
{
    public interface IModifySeriesValueForTestPurpose
    {
        public List<SeriesValue> Invoke(List<SeriesValue> seriesValues, int itemNumber);

    }
}
