@ModelType IEnumerable(Of MVCApp.MVCApp.Models.EmployeeModel)
@Code
ViewData("Title") = "ViewEmployees"
End Code

<h2>Lista de Empregados</h2>

<p>
    @Html.ActionLink("Registar um novo empregado", "SignUp")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.IDEmpregado)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PrimeiroNome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UltimoNome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Contacto)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NumContribuinte)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Morada)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.IDEmpregado)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PrimeiroNome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UltimoNome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Contacto)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NumContribuinte)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Morada)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
