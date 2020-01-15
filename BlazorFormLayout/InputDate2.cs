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
    public class InputDate2<TValue> : InputDate<TValue>
    {
        protected override string FormatValueAsString(TValue value)
        {
            if (value is DateTime dt)
            {
                if (dt.Year == 1) return string.Empty; // handle un-set dates
            }
            return base.FormatValueAsString(value);
        }
    }
//{
//    /// <summary>
//    /// Alternative version of InputDate that handles unset dates correctly
//    /// </summary>
//    public class InputDate2 : InputBase<DateTime>
//    {

//        private const string DateFormat = "yyyy-MM-dd"; // Compatible with HTML date inputs

//        /// <summary>
//        /// Gets or sets the error message used when displaying an a parsing error.
//        /// </summary>
//        [Parameter] public string ParsingErrorMessage { get; set; } = "The {0} field must be a date.";

//        /// <inheritdoc />
//        protected override void BuildRenderTree(RenderTreeBuilder builder)
//        {
//            builder.OpenElement(0, "input");
//            builder.AddMultipleAttributes(1, AdditionalAttributes);
//            builder.AddAttribute(2, "type", "date");
//            builder.AddAttribute(3, "class", CssClass);
//            builder.AddAttribute(4, "value", BindConverter.FormatValue(CurrentValueAsString));
//            builder.AddAttribute(5, "onchange", EventCallback.Factory.CreateBinder<string>(this, __value => CurrentValueAsString = __value, CurrentValueAsString));
//            builder.CloseElement();
//        }

//        /// <inheritdoc />
//        protected override string FormatValueAsString(DateTime value)
//        {
//            switch (value)
//            {
//                case DateTime dateTimeValue:
//                    // check for 'unset' value
//                    if (value.Year == 0001) return string.Empty;
//                    return BindConverter.FormatValue(dateTimeValue, DateFormat, CultureInfo.InvariantCulture);
//                default:
//                    return string.Empty; // Handles null for Nullable<DateTime>, etc.
//            }
//        }

//        /// <inheritdoc />
//        protected override bool TryParseValueFromString(string value, out DateTime result, out string validationErrorMessage)
//        {
//            // Unwrap nullable types. We don't have to deal with receiving empty values for nullable
//            // types here, because the underlying InputBase already covers that.
//            var targetType = typeof(DateTime);

//            bool success;
//            if (targetType == typeof(DateTime))
//            {
//                success = TryParseDateTime(value, out result);
//            }
//            else
//            {
//                throw new InvalidOperationException($"The type '{targetType}' is not a supported date type.");
//            }

//            if (success)
//            {
//                validationErrorMessage = null;
//                return true;
//            }
//            else
//            {
//                validationErrorMessage = string.Format(ParsingErrorMessage, FieldIdentifier.FieldName);
//                return false;
//            }
//        }

//        static bool TryParseDateTime(string value, out DateTime result)
//        {
//            var success = BindConverter.TryConvertToDateTime(value, CultureInfo.InvariantCulture, DateFormat, out var parsedValue);
//            if (success)
//            {
//                result = (DateTime)(object)parsedValue;
//                return true;
//            }
//            else
//            {
//                result = default;
//                return false;
//            }
//        }

//    }
}
