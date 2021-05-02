using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2.LW2_1
{
    class QuantitativeAttribute<T> : DataGroupingTool<T>
    {


        protected override Dictionary<T, List<Employee>> Group()
        {
            var N = SourceData.Select(x => x.WorkExperience).Distinct().Count();
            var n = (int)Math.Log2(N) + 1;

            var xMax = SourceData.Aggregate((x, y) => x.Age > y.Age ? x : y).Age;
            var xMin = SourceData.Aggregate((x, y) => x.Age < y.Age ? x : y).Age;
            var length = (int)Math.Ceiling( (xMax - xMin) / (double)n );

            var limit = xMin;
            var nLimit = limit + length;

            for (int i = 0; i < n; i++)
            {
                var dataGroups = new List<Employee>();
                var group = $"{limit} - {nLimit}";
                
                foreach (var value in SourceData)
                {
                    if (value.Age >= limit && value.Age < nLimit)
                    {
                        dataGroups.Add(value);
                    }
                }

                _grouppedData.Add((T)Convert.ChangeType(group, typeof(T)), dataGroups);

                limit = nLimit;
                nLimit += length;
            }

            return _grouppedData;
        }
    }
}
