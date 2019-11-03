# BlazorFormLayout
Helper components for rendering form content in Blazor using Bootstrap v4

## Overview

When creating forms in web apps, I find all the boiler-plate HTML required in Bootstrap 4 
to be largely repetitive and tedious. With the Razor component model in Blazor we can 
create components to hide away all that tedious nested HTML `div` tags and focus on the fields: 

### Example
This code creates a Bootstrap form with several bound fields.
```html
<EditForm>
  <BsLayout Orientation="Horizontal">
    <BsInputText @bind-Value="model.Name" Label="Customer name" >
    <BsInputText @bind-Value="model.Contact" Label="Contact" >
    <BsInputCheckbox @bind-Value="model.IsPriorityCustomer" Label="Priority" />
    <BsInputNumber @bind-Value="model.Units" Label="Units to Order" />
    <BsInputNumber @bind-Value="model.Price" Label="Unit Price" />
    <BsGroup Label="Select colour">
      <input type='color' @bind="model.FavouriteColour" />
    </BsGroup>
    <BsDropdown @bind-Value="model.CustomerType" @options="CustomerTypeList" Label="Business Type" />
    <BsStaticText Value="model.TotalPrice" />
  </BsLayout>
</EditForm>
```

The `BsLayout` is a container providing cascading control over the layout of the child 
elements. This container is optional - if it's not present, the controls will use a default layout.

The `BsInputText` is a series of Bootstrap `div` tags surrounding a `InputText` component 
bound to the model property specified in the `@bind-Value` attribute.

The `BsGroup` is used when you want a non-standard input item, where a `BsInput..` component 
isn't available.


Rendered example: [tbc]

```
### TODO
```

## Getting Started

## Documentation