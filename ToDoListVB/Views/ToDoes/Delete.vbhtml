@ModelType ToDoListVB.ToDo
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this task?</h3>
<div>
    <hr />
    <dl class="dl-horizontal delete-form">
        <dt>
            Description:
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        <dt>
            Is it done?
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IsDone)
        </dd>

        <dt>
            Creation/Edit date:
        </dt>

        <dd>
            @Convert.ToDateTime(Model.CreationDate).ToString("dd/MM/yyyy, HH:mm")
        </dd>

        <dt>
            Importance:
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Importance)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <a href="@Url.Action("Index", "ToDoes")" class="btn btn-info">Back to list</a>
            <input type="submit" value="Delete" class="btn btn-danger" />
        </div>
    End Using
</div>
