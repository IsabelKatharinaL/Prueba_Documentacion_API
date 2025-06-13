Imports System.Web.Http
Imports WebActivatorEx
Imports Swashbuckle.Application

<Assembly: PreApplicationStartMethod(GetType(SwaggerConfig), "Register")>

Public Class SwaggerConfig
    Public Shared Sub Register()
        Dim thisConfig = GlobalConfiguration.Configuration

        thisConfig.EnableSwagger(
            Sub(c)
                ' Información básica del API
                c.SingleApiVersion("v1", "Prueba docu")

                ' (Opcional) Incluir comentarios XML si los tienes activados en el proyecto
                c.IncludeXmlComments(GetXmlCommentsPath())
            End Sub
        ).EnableSwaggerUi() ' Habilita la interfaz gráfica de Swagger UI
    End Sub

    ' Ruta del archivo de comentarios XML generado por VB.NET
    Private Shared Function GetXmlCommentsPath() As String
        Return String.Format("{0}\bin\Prueba_Documentacion_API.XML", AppDomain.CurrentDomain.BaseDirectory)
    End Function
End Class
