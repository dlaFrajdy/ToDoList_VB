@ModelType IEnumerable(Of ToDoListVB.ToDo)

<table class="table table-hover">
    <tr>
        <th>
            <p>Description:</p>
        </th>
        <th>
            <p>Is it done?</p>
        </th>
        <th>
            <p>Creation/edit date:</p>
        </th>
        <th>
            <p>Importance:</p>
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
                @Convert.ToDateTime(item.CreationDate).ToString("dd/MM/yyyy, HH:mm")
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Importance)
            </td>
            <td>
                <a href="@Url.Action("Edit", "ToDoes", New With {.id = item.ID})" class="btn-xs btn-warning glyphicon glyphicon-pencil"></a>
                <a href="@Url.Action("Delete", "ToDoes", New With {.id = item.ID})" class="btn-xs btn-danger glyphicon glyphicon-remove"></a>
            </td>
        </tr>
    Next

</table>



<script src="~/Custom_Scripts/AddCheckBoxListener.js"></script>