Imports System.Web.Http
Imports System.Web.Optimization

Public Class WebApiApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        ' Si necesitas ajustar el formateador para recibir/devolver JSON en lugar de XML por defecto:
        GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes.Add(New System.Net.Http.Headers.MediaTypeHeaderValue("text/html"))
    End Sub
End Class
