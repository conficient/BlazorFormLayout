# Bootstrap 4.x Form Group

Form groups handle layout of labels, controls and other related elements inside 
`<form>` tags.

https://getbootstrap.com/docs/4.5/components/forms/#form-groups

Sample from Bootstrap Website:
```html
<form>
  <div class="form-group">
    <label for="formGroupExampleInput">Example label</label>
    <input type="text" class="form-control" id="formGroupExampleInput" placeholder="Example input placeholder">
  </div>
</form>
```

BlazorFormLayout uses this format for vertical forms (the standard layout).

If a Horizontal layout is specified, BlazorFormLayout will render thus:
```html
<form>
  <div class="form-group row">
    <label for="formGroupExampleInput" class="col-sm-2 col-form-label">Example label</label>
    <div class="col-sm-10">
        <input type="text" class="form-control" id="formGroupExampleInput" placeholder="Example input placeholder">
    </div>
  </div>
</form>
```

