@ModelType IEnumerable(Of ToDoListVB.ToDo)

@Code
    ViewData("Title") = "To Do List App"
End Code

<h2>Your to-do list:</h2>

<div id="tableDiv"></div>
<div class="createTask">
    @Html.ActionLink("Add new task", "Create")
</div>

<div class="col-md-12 mainQuote">
    <blockquote>
        <p>Always deliver more than expected.</p>
        <footer>Larry Page, co-founder of Google</footer>
    </blockquote>
</div>
@section Scripts
    <script src="~/Scripts/jquery.unobtrusive-ajax.min.js"></script>
    <script src="~/Custom_Scripts/BuildTable.js"></script>
End Section
