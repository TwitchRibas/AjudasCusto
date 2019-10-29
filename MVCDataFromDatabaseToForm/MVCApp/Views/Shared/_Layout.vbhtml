<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <!--     Fonts and icons     -->
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
    <!-- CSS Files -->
    <link href="./assets/css/material-kit.css?v=2.0.6" rel="stylesheet" />
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header" align="center">
                @Html.ActionLink("Ajudas de Custo", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
                @Html.ActionLink("Deslocação", "Contact", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
                @Html.ActionLink("Registar Empregado", "SignUp", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
                @Html.ActionLink("Ver lista de empregados", "ViewEmployees", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - ASP.NET Application by Rui Ribeiro</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
