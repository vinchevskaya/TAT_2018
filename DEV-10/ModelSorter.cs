using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    /// <summary>
    /// Sorting by model.
    /// </summary>
    public class ModelSorter
    {
        public List<Car> SortByDescendingNumberModels(List<Car> list)
        {
            var sortedNumberModelList = list.OrderByDescending(model => model.ModelNumber);
            return sortedNumberModelList.ToList();
        }
    }
}
