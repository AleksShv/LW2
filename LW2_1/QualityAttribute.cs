using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW2.LW2_1
{
    class QualityAttribute : IGroupingTool
    {
        public Dictionary<object, List<T>> Group<T>(IEnumerable<T> data, string propertyName)
        {
            var gropedData = new Dictionary<object, List<T>>();
            var property = typeof(T).GetProperty(propertyName);

            var N = Enum.GetValues(property.PropertyType).Length;
            var n = (int)Math.Log2(N) + 1;

            for (int i = 0; i < n; i++)
            {
                var group = Enum.GetValues(property.PropertyType).GetValue(i);
                var dataGroups = new List<T>();

                foreach (var value in data)
                {
                    if (group.Equals(property.GetValue(value)))
                    {
                        dataGroups.Add(value);
                    }
                }

                gropedData.Add(group, dataGroups);
            }

            return gropedData;
        }
    }
}
