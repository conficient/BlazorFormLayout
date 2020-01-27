# BlazorFormLayout

## Getting Started

Install BlazorFormLayout into any Blazor client project using Nuget:

```cmd
nuget install-package BlazorFormLayout
```

Then edit your `_Imports.razor` file to include the line:
```cs
@using BlazorFormLayout
```

### Concepts

Blazor Form Layouts are designed to enhance the standard Blazor `<EditForm>` 
component by adding boilerplate Bootstrap layout an validation. All Blazor form
layout components are prefixed with `Bs`.

here is an example of the simplest possible form:
```html
<EditForm Model="example">
  <BsLayout Orientation="Horizontal" EditMode="Edit" >
    @* this sets the form layout style and edit mode *@
    <BsText @bind-Value="@example.Name" Label="Your name" />
  </BsLayout>
<EditForm>
@code
{
  class Example 
  { 
     public string Name {get;set;}
  }

  Example example = new Example();
}
```

### BsLayout

The `BsLayout` component sets the form layout and status for the controls within 
the layout's child content. If the `EditMode` is set to `ReadOnly` the Form Layout 
controls add the `disabled` attribute and stop being editable.

This means you can have a form that opens as read-only initially, and then
enable editing at a later point, e.g. if the user clicks an `Edit` button.

### BsText

The `BsText` component binds to a string property. All `Bs` controls use the 
`@bind-Value` syntax to bind to a property in the model. The `Label` parameter
sets the text shown in the label.
