using System.Web.Http;
using WebActivatorEx;
using DingTalk;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace DingTalk
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "DingTalk");
                        //���XML����
                        c.IncludeXmlComments(GetXmlCommentsPath());
                    })
                .EnableSwaggerUi(c =>
                    {
                      
                    });
        }

        //���XML����
        private static string GetXmlCommentsPath()
        {
            return string.Format("{0}/bin/DingTalk.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
