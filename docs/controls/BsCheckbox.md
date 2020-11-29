# BsCheckbox Component

Renders a form group with a `<input type='checkbox'>` control within an `EditForm`.

### Example
```html
<BsCheckbox @bind-Value="@example.AcceptTerms" Label="Accept terms" CheckboxLabel="I agree" />
```

#### CheckboxLabel

The `Label` property defines text that appears in the form label area in the same way as other `Bs..` controls.

The `CheckboxLabel` property applies to text that appears adjacent to the checkbox. The label is linked to 
the input control using the `for` attribute and the `Id` property. If the `Id` is not set, a random Id is 
used to link these, so that clicking the text will click the checkbox.
