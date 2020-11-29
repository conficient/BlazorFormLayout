# BsRadioEnum Component

Renders a form group with a series `<input type='radio'>` controls within an `EditForm` for binding to an `enum` value.

### Example
```html
<BsRadioEnum @bind-Value="@model.DeliveryOption" Label="Delivery option" Inline="false" />
```

### Properties

As with `<BsDropdownEnum>` the values and names are derived from 
the bound enum type.

The `Inline` property is used to control the layout of the 
radio button values. The default value is `true` which displays the 
values inline. Setting this to `false` will display one radio option 
per line.