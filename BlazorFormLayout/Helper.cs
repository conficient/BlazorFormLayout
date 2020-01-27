using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFormLayout
{
    /// <summary>
    /// Helper classes
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Get a set of key-pair values from an Enum type
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <returns></returns>
        public static Dictionary<TEnum, string> GetValueOptions<TEnum>()
        {
            var result = new Dictionary<TEnum, string>();
            var names = Enum.GetNames(typeof(TEnum)).Cast<string>().ToList();
            var values = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();
            for (int i = 0; i < names.Count; i++)
            {
                result.Add(values[i], names[i]);
            }
            return result;
        }

    }

}
