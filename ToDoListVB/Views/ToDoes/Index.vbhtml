@ModelType ToDoListVB.ToDo

@Code
    ViewData("Title") = "To Do List App"
End Code

<h2>Your to-do list</h2>

<div id="tableDiv"></div>
<div class="createTask">
    @Html.ActionLink("Add new task", "Create")
</div>


@section Scripts
    <script src="~/Scripts/jquery.unobtrusive-ajax.min.js"></script>
    <script src="~/Custom_Scripts/BuildTable.js"></script>
End Section