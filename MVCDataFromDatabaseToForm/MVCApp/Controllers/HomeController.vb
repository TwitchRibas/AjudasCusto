Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DataLibrary
Imports Rotativa
Imports DataLibrary.BusinessLogic.EmployeeProcessor
Imports MVCApp.MVCApp.Models

Namespace MVCApp.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function About() As ActionResult
            ViewBag.Message = "Your application description page."
            Return View()
        End Function

        Public Function Contact() As ActionResult
            ViewBag.Message = "Your contact page."
            Return View()
        End Function

        Public Function ViewEmployees() As ActionResult
            ViewBag.Message = "Employees List"
            Dim data = LoadEmployees()
            Dim employees As List(Of EmployeeModel) = New List(Of EmployeeModel)()

            For Each row In data
                employees.Add(New EmployeeModel With {
                    .IDEmpregado = row.IDEmpregado,
                    .PrimeiroNome = row.PrimeiroNome,
                    .UltimoNome = row.UltimoNome,
                    .Contacto = row.Contacto,
                    .NumContribuinte = row.NumContribuinte,
                    .Morada = row.Morada
                })
            Next

            Return View(employees)
        End Function

        Public Function SignUp() As ActionResult
            ViewBag.Message = "Employee Sign Up"
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Public Function SignUp(ByVal model As EmployeeModel) As ActionResult
            If ModelState.IsValid Then
                Dim recordsCreated As Integer = CreateEmployee(model.IDEmpregado, model.PrimeiroNome, model.UltimoNome, model.Contacto, model.NumContribuinte, model.Morada)
                Return RedirectToAction("Index")
            End If

            Return View()
        End Function

        Public Function ExportAjudas() As ActionResult
            Return New ActionAsPdf("Index") With
        {
        .FileName = Server.MapPath("~/Content/AjudasCusto.pdf")
        }
        End Function
    End Class
End Namespace
