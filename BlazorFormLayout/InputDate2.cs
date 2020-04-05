using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFormLayout
{ 
    /// <summary>
    /// Overrides the standard InputDate behaviour by returning an empty string
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public class InputDate2<TValue> : InputDate<TValue>
    {
        protected override string FormatValueAsString(TValue value)
        {
            if (value is DateTime dt)
            {
                if(dt == DateTime.MinValue)
                    return string.Empty; // handle dates with no value set
            }
            return base.FormatValueAsString(value);
        }
    }

}
