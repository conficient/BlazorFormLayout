using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorFormLayout
{
    public class BsControlBase<TValue> : ComponentBase
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
        [CascadingParameter] public EditMode Mode {get;set;}

        /// <summary>
        /// The bound value
        /// </summary>
        [Parameter] public TValue Value { get; set; }

        /// <summary>
        /// Value changed callback
        /// </summary>
        [Parameter] public EventCallback<TValue> ValueChanged { get; set; }

}
}
