# BsDate Component

Renders a form group with a `<input type='date'>` control within an `EditForm` for binding to a datetime value.

### Example
```html
<BsDate @bind-Value="@example.DeliverOn" Label="Delivery Date" />
```

### Unset Dates
The `BsDate` control will leave the control empty if a non-nullable DateTime value is not set (e.g. equals 
`DateTime.MinValue`). This is unlike the standard Blazor `<InputDate>` control, which when bound to a 
`DateTime` value which has not been set, it shows `'01-01-0001'` as the value. The underlying bound value will
still be `01/01/0001` however.

### MinDate and MaxDate

The control supports two optional properties: `MinDate` and `MaxDate`. Setting either will restrict the HTML 
control calendar rendering so that dates outside the valid range cannot be selected.
