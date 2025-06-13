Imports System.Web.Http
Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits ApiController

        ' GET: api/login
        '<summary>
        ' Devuelve un saludo genérico.
        '</summary>
        '<returns>Un saludo en formato de texto.</returns>
        '<response code="200" message="Saludo exitoso."/>
        <Http.HttpGet>
        <Http.Route("api/login")>
        Public Function Hola() As IHttpActionResult
            Return Ok("Hola, mundo!")
        End Function

        'GET: api/login/isa
        '<summary>
        ' Devuelve un saludo personalizado para el usuario especificado.
        '</summary>
        '<param name="nombre">El nombre del usuario.</param>
        '<returns>Un saludo personalizado en formato de texto.</returns>
        '<response code="200" message="Saludo exitoso."/>
        '<response code="400" message="El nombre no puede estar vacío."/>
        <Http.HttpGet>
        <Http.Route("api/login/{nombre}")>
        Public Function HolaUsuario(ByVal nombre As String) As IHttpActionResult
            If nombre Is Nothing OrElse nombre.Trim() = String.Empty Then Return BadRequest("El nombre no puede estar vacío.")

            Return Ok("Hola, " & nombre)
        End Function
    End Class
End Namespace