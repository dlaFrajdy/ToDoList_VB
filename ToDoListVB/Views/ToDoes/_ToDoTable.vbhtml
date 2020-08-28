@ModelType IEnumerable(Of ToDoListVB.ToDo)

<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IsDone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CreationDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Importance)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Description)
            </td>
            <td>
                @Html.CheckBoxFor(Function(modelItem) item.IsDone, New With {.id = item.ID, .Class = "ActiveCheck"})
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.CreationDate)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Importance)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.ID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.ID})
            </td>
        </tr>
    Next

</table>

<script src="~/Custom_Scripts/AddCheckBoxListener.js"></script>