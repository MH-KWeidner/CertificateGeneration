using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interpolation
{
    public interface IInterpolate
    {
        public void Interpolate(Series series);
    }
}
