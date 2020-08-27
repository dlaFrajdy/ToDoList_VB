@ModelType IEnumerable(Of ToDoListVB.ToDo)
@Code
    ViewData("Title") = "SearchIndex"
End Code

<h2>SearchIndex</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
@Code
    ViewData("Title") = "SearchIndex"
    Using (Html.BeginForm())
        @<p>
            Title: @Html.TextBox("id")
            <input type="submit" value="Filter" />
        </p>
    End Using
End Code
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IsDone)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Description)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.IsDone)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.ID}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.ID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.ID})
            </td>
        </tr>
    Next

</table>
