# BsLayout

This container control is used to cascade the form layout and form editing status to the child controls.

Example
```html
    <EditForm>
      <BsLayout Orientation="Horizontal" EditMode="Edit" >
        <!-- control components go here -->
      </BsLayout>
    </EditForm>
```

### Orientation Parameter

This parameter controls how the Bs components inside are rendered. Bootstrap 4 has two supported layouts. The
default is Vertical, so form groups are rendered like this:
```html
example
```
The alternative is Horizontal, which renders like this:
```html

```
