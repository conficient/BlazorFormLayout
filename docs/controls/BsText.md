# BsText Component

Renders a form group with a `<input>` control within an `EditForm` for text input.

### Example
```html
<BsText @bind-Value="@example.Name" Label="Your name" />
```

#### Validation

If you wish to include

As with all control components, any additional attributes are passed to the `<input>` control, e.g.

```html
<BsText @bind-Value="@example.Name" Label="Your name" placeholder="enter your name" maxlen="32" />
```


