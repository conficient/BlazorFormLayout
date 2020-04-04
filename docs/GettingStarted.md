# BlazorFormLayout

## Getting Started

Install BlazorFormLayout into any Blazor client project using Nuget:

```shell
nuget install-package BlazorFormLayout
```

Then edit your `_Imports.razor` file to include the line:
```csharp
@using BlazorFormLayout
```
This brings the BlazorFormLayout components namespace into scope.

## Concepts

Blazor Form Layouts help create forms using the [Bootstrap 4 form groups](https://getbootstrap.com/docs/4.4/components/forms/#form-groups) 
structure in conjuction with the Blazor `<EditForm>` component, by adding boilerplate Bootstrap from-group layout and validation.

All Blazor Form Layout components are prefixed with `Bs`.

The components should be used within a Blazor `<EditForm>` component to provide the editing and validation context. 

You can also optionally put the input components withing a `BsLayout` container component to control the orientation and 
edit state of the controls.

## Example
Here is an example of the simplest possible form:
```html
<EditForm Model="example">
  <BsLayout Orientation="Horizontal" EditMode="Edit" >
    @* this sets the form layout style and edit mode *@
    <BsText @bind-Value="@example.Name" Label="Your name" />
  </BsLayout>
<EditForm>
@code
{
  // the model class
  class Example 
  { 
     public string Name {get;set;}
  }

  Example example = new Example();
}
```

#### BsLayout

The `BsLayout` component sets the form layout and status for the controls within 
the BsLayout's child content. If the `EditMode` is set to `ReadOnly` the Form Layout 
controls add the `disabled` attribute and stop being editable.

This means you can have a form that opens as read-only initially, and then
enable editing at a later point, e.g. if the user clicks an `Edit` button.

#### BsText

The `BsText` component binds to a string property or value. All `Bs` controls use the 
`@bind-Value` syntax to bind to a property in the model. The `Label` parameter
sets the text shown in the label.
