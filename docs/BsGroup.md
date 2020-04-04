# BsGroup Component

This container component is used to render a bootstrap form field group for your own controls or content.

The standard set of `Bs..` input controls should cover many use cases but there will be many situations that require input 
controls of a different type. This component will place the `ChildContent`
inside a `<div>` of a [Bootstrap 4 form group](https://getbootstrap.com/docs/4.4/components/forms/#form-groups).

For example
```html
<BsGroup Label="test" Id="t1" >
  <!-- your content here -->
</BsGroup>
```
will render the following HTML in `Horizontal` orientation mode:
```html
<div class="form-group row">
    <label for="t1" class="col-sm-4 col-md-3 col-form-label">test</label>
    <div class="col-sm-8 col-md-9">
        <!-- your content here -->
    </div>
</div>
```

### Parameters

 - **Id**: the `id` of the contained input control [optional]. Will set the `for` attribute of the label if defined.
 - **Label**: the text to show in the label

