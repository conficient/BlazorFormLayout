# BsDropdown Component

Renders a form group with a `<select>` control within an `EditForm` for selecting a value from a dropdown.

### Example
```html
<BsDropdown @bind-Value="@model.CostRegion" Label="Cost region" ValueOptions="@model.GetCostRegions()" />
```

### Properties

The `BsDropdown` control requires a `ValueOptions` property to be set which
lists the possible values to display. This should be a `Dictionary<TType, string>` 
where `TType` is the bound type and the string is the displayed.


If you wish to show a dropdown bound to an `enum` value use the 
[`<BsDropdownEnum>`](BsDropdownEnum) 
component.