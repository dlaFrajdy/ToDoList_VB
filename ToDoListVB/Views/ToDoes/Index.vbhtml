@ModelType ToDoListVB.ToDo

@Code
    ViewData("Title") = "Lista zadań ToDo"
End Code

<h2>Index</h2>

<div id="tableDiv"></div>
<p>
    @Html.ActionLink("Create New", "Create")
</p>


@section Scripts
    <script src="~/Scripts/jquery.unobtrusive-ajax.min.js"></script>
    <script src="~/Custom_Scripts/BuildTable.js"></script>
End Section