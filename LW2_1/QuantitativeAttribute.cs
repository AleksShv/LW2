using System;
using System.Collections.Generic;
using System.Linq;

namespace LW2.LW2_1
{
    class QuantitativeAttribute : IGroupingTool
    {
        public Dictionary<object, List<T>> Group<T>(IEnumerable<T> data, string propertyName)
        {
            var groupedData = new Dictionary<object, List<T>>();
            var property = typeof(T).GetProperty(propertyName);

            var N = data.Select(x => property.GetValue(x)).Distinct().Count();
            var n = (int)Math.Log2(N) + 1;

            var maxValueObject = data.Aggregate((x, y) => (int)property.GetValue(x) >= (int)property.GetValue(y) ? x : y);
            var minValueObject = data.Aggregate((x, y) => (int)property.GetValue(x) < (int)property.GetValue(y) ? x : y);

            var maxValue = (int)property.GetValue(maxValueObject);
            var minValue = (int)property.GetValue(minValueObject);

            var length = (int)Math.Ceiling((maxValue - minValue) / (double)n);

            var minLimit = minValue;
            var maxLimit = minLimit + length;

            for (int i = 0; i < n; i++)
            {
                var dataGroups = new List<T>();
                var group = $"from {minLimit} to {maxLimit}";

                foreach (var value in data)
                {
                    if ((int)property.GetValue(value) >= minLimit && (int)property.GetValue(value) < maxLimit)
                    {
                        dataGroups.Add(value);
                    }
                }

                groupedData.Add(group, dataGroups);

                minLimit = maxLimit;
                maxLimit += length;
            }

            return groupedData;
        }
    }
}
