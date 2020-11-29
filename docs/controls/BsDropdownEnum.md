# BsDropdownEnum Component

Renders a form group with a `<select>` control within an `EditForm` for binding to an `enum` value.

### Example
```html
<BsDropdownEnum @bind-Value="@model.CustomerType" Label="Business type" />
```

### Properties

Unlike the `<BsDropdown>` this component does not need a list of values as 
it determines this from  the `enum` type, inferred from the bound value.