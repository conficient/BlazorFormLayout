# BsNumber Component

Renders a form group with a `<input type='number'>` control within an `EditForm` for text input.

### Example
```html
<BsNumber @bind-Value="@example.Price" Label="Unit price" min='0.01' />
```

This can be bound any C# number type, e.g.
 - int
 - long
 - short
 - decimal
 - single
 - double

And to any nullable variant of these.

---
### Attributes
#### `step` attribute

The step size determines the resolution of the value when 
using the up/down value arrows in the browser.

By default the step value is null which uses the browser 
default. If the bound value is a `decimal` or 
`Nullable<decimal>` the step size will default to 0.01.

You can override by setting the `step` attribute, e.g.

```html
<BsNumber @bind-Value="@example.Price" Label="Unit price in whole units" step='1' />
```


#### `min` and `max` attributes

As with other controls, additional attributes are passed to 
the `<input>` control.

The `min` and `max` attributes will set the minimum and 
maximum values permitted by the browser.

For example a `<BsNumber>` bound to a quantity value might 
set `min='1'` or `min='0'`.

##### min
```html
<BsNumber @bind-Value="@example.Price" Label="Unit price (at least $5)" min='5' />
```

##### max
```html
<BsNumber @bind-Value="@example.Discount" Label="Discount (max 20%)" min='0' max='20' />
```
