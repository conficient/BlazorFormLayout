using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


// reference: https://chrissainty.com/building-custom-input-components-for-blazor-using-inputbase/ 

namespace BlazorFormLayout
{
    public abstract class BsControlBase<TValue> : InputBase<TValue>
    {
        /// <summary>
        /// Label for the form control
        /// </summary>
        [Parameter] public string Label { get; set; }

        /// <summary>
        /// `id` for the input control
        /// </summary>
        [Parameter] public string Id { get; set; }

        /// <summary>
        /// Edit mode (cascaded param from the BsLayout control)
        /// </summary>
        [CascadingParameter] public EditMode Mode { get; set; }

        /// <summary>
        /// Validation parameter - if blank, no validation is shown for this control
        /// </summary>
        [Parameter] public Expression<Func<TValue>> ValidationFor { get; set; }
    }
}
