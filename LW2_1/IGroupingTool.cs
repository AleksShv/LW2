using System;
using System.Collections.Generic;

namespace LW2.LW2_1
{
    interface IGroupingTool
    {
        Dictionary<object, List<T>> Group<T>(IEnumerable<T> data, string propertyName);
    }
}
