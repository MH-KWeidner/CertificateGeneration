using Models;

namespace Models.Modifiers
{
    public class ZeroReduction : IModifySeries
    {
        public List<SeriesValue> Modify(List<SeriesValue> seriesValues)
        {
            seriesValues?.OrderBy(sv => sv.AppliedForce).Where(sv => sv.AppliedForce > 0).ToList();

            return seriesValues;
        }
    }
}
