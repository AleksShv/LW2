using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2.LW2_1
{
    class QualityAttribute<T> : DataGroupingTool<T>
    {
        protected override Dictionary<T, List<Employee>> Group()
        {
            var N = Enum.GetValues(typeof(T)).Length;
            var n = (int)Math.Log2(N) + 1;

            for (int i = 0; i < n; i++)
            {
                var group = (T)Enum.GetValues(typeof(T)).GetValue(i);
                var dataGroups = new List<Employee>();

                foreach (var value in SourceData)
                {
                    if (group.Equals(value.Gender))
                    {
                        dataGroups.Add(value);
                    }
                }

                _grouppedData.Add(group, dataGroups);
            }

            return _grouppedData;
        }
    }
}
