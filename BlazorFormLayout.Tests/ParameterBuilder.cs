using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace BlazorFormLayout.Tests
{
    /// <summary>
    /// Helper class to set up a series of parameters for a Razor component
    /// </summary>
    public class ParameterBuilder
    {
        /// <summary>
        /// internal list of params
        /// </summary>
        private readonly Dictionary<string, object> _dict;

        /// <summary>
        /// c'tor
        /// </summary>
        public ParameterBuilder() => _dict = new Dictionary<string, object>();

        /// <summary>
        /// Add a new parameter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public ParameterBuilder Add(string name, object value) 
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            _dict.Add(name, value);
            return this;
        }

        /// <summary>
        /// Return parameter view
        /// </summary>
        /// <returns></returns>
        public ParameterView ToParameterView()
        {
            return ParameterView.FromDictionary(_dict);
        }
    }

}
