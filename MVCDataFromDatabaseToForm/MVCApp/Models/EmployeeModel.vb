Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web

Namespace MVCApp.Models
    Public Class EmployeeModel
        <Display(Name:="ID do Empregado")>
        <Range(1, 999999, ErrorMessage:="É necessário inserir um ID de Empregado válido!")>
        Public Property IDEmpregado As Integer

        <Display(Name:="Primeiro Nome")>
        <Required(ErrorMessage:="É necessário inserir um Primeiro Nome válido!")>
        Public Property PrimeiroNome As String

        <Display(Name:="Último Nome")>
        <Required(ErrorMessage:="É necessário inserir um Último Nome válido!")>
        Public Property UltimoNome As String

        <Display(Name:="Contacto")>
        <Required(ErrorMessage:="É necessário inserir um Contacto válido!")>
        Public Property Contacto As Integer

        <Display(Name:="Número de Contribuinte")>
        <Required(ErrorMessage:="É necessário inserir um Número de Contribuinte válido!")>
        Public Property NumContribuinte As Integer

        <Display(Name:="Morada")>
        <Required(ErrorMessage:="É necessário inserir uma Morada válida!")>
        Public Property Morada As String

    End Class
End Namespace
