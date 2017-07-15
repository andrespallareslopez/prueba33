using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;

using prueba33.App_Start;

using Ninject;
using System.Reflection;
using System.Net.Http.Formatting;

using System.Web.Http.Filters;
using System.Net.Http;
using System.IO;

[assembly: OwinStartup(typeof(prueba33.Startup))]

namespace prueba33
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration config = new HttpConfiguration();
            /*
            config.Routes.MapHttpRoute(
                "default",
                "api/{controller}",
                new {controller="Home"}
                );
            
            
            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = RouteParameter.Optional }
            );
            */
            config.MapHttpAttributeRoutes(); //Esto es importante ponerlo para que funcione [Route(...)]

            config.Routes.MapHttpRoute(
               name: "ApiByOtherId",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
            );
            

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            var formatter = new JsonMediaTypeFormatter();

            config.Formatters.Add(new JsonMediaTypeFormatter());

            //config.Filters.Add( new DeflateCompressionAttribute() );
            //config.MessageHandlers.Add(new EncodingDelegateHandler());
            //app.UseWebApi(config); //con ninject no se utiliza esto
            app.UseNinjectMiddleware(() => NinjectConfig.CreateKernel.Value);
            app.UseNinjectWebApi(config);

            //app.UseNinjectMiddleware(CreateKernel).UseNinjectWebApi(config);
            //GlobalConfiguration.Configuration.Formatters.Clear();
           


            //GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());

            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("hello word");
            });
        }
        /*
        private static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel;
        }
        */

    }
    /*
    public class DeflateCompressionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actContext)
        {
            var content = actContext.Response.Content;
            var bytes = content == null ? null : content.ReadAsByteArrayAsync().Result;
            var zlibbedContent = bytes == null ? new byte[0] : CompressionHelper.DeflateByte(bytes);

            actContext.Response.Content = new ByteArrayContent(zlibbedContent);
            actContext.Response.Content.Headers.Remove("Content-Type");
            actContext.Response.Content.Headers.Add("Content-encoding", "deflate");
            actContext.Response.Content.Headers.Add("Content-Type", "application/json");
            base.OnActionExecuted(actContext);

        }
    }
    public class CompressionHelper
    {
        public static byte[] DeflateByte(byte[] str)
        {
            if (str == null)
            {
                return null;
            }
            using (var output = new MemoryStream())
            {
                using (var compressor = new Ionic.Zlib.DeflateStream(output, Ionic.Zlib.CompressionMode.Compress, Ionic.Zlib.CompressionLevel.BestSpeed))
                {
                    compressor.Write(str, 0, str.Length);
                }
                return output.ToArray();
            }
        }
    }
    */
}
