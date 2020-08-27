# Bs Input Control Common Behaviours

All the _BlazorFormLayout_ input controls have the following common behaviours.

### Validation

The controls all support validation using the [Blazor EditForm validation functionality](https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-3.1#validator-components).

If you want to display validation error next to a _BlazorFormLayout_ input control, you need to add 
the attribute `ValidationFor="@(() => model.PropertyName)"`. For example
```html
<BsText @bind-Value="@example.Name" Label="Your name" ValidationFor="@(() => example.Name)" />
```

### TODO

Enable valid and invalid ? Enable Boostrap CSS translation?

You can also use the `<ValidationSummary />` component anywhere within the `EditForm`.

### Additional Attributes



