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
        /// Adjusts Blazor form validation css to use bootstrap validation
        /// </summary>
        /// <param name="inputClassNames"></param>
        /// <returns></returns>
        protected string FixClassNames(string inputClassNames)
        {
            if (string.IsNullOrWhiteSpace(inputClassNames)) return string.Empty;

            //NOTE: Notice the space in front of the class name, this is to ensure we get
            // the suffix to our existing form-control class set from the mark up and NOT
            // half of an invalid tag.  We could use a reg-ex but that might be a bit
            // too slow for the UI renedering to stay smooth.

            // The invalid string shall always be fixed up, as we can never get it until the
            // element has chacked at least once by an attempted submit.
            string result = inputClassNames.Replace(" invalid", " is-invalid");

            // The valid tag is on by default, and to keep consistancy with BS4 we only want
            // it to appear either when our field is modified, or we've tried a submit
            if (inputClassNames.Contains("modified"))
            {
                result = result.Replace(" valid", " is-valid");
            }

            return result;
        }
    }
}
