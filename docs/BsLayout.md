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

This parameter controls how the `Bs..` components inside are rendered. Bootstrap 4 has two supported layouts. The
default is Vertical, so form groups are rendered like this:
```html
<form>
  <div class="form-group">
    <label class="">Your name</label>
    <div class="">
      <input type="text" class="form-control">
    </div>
  </div>
</form>
```
The alternative is Horizontal, which renders like this:
```html
<form>
  <div class="form-group row">
    <label class="col-sm-4 col-md-3 col-form-label">Your name</label>
    <div class="col-sm-8 col-md-9">
        <input type="text" class="form-control">
    </div>
  </div>
</form>
```

### EditMode Parameter

This parameter controls how `Bs...` input are rendered. It's useful if want to 
show a form, or a section of a form, as read-only. The 
`Bs..` editors within the layout will be rendered as read-only
(i.e. with the `disabled` attribute set).
