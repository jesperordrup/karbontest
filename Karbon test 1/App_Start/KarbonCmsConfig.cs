using Karbon.Cms.Web;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Karbon_test_1.App_Start.KarbonCmsConfig), "Initialize")]
namespace Karbon_test_1.App_Start
{
    public class KarbonCmsConfig
    {
        public static void Initialize()
        {
            new WebBootManager().Initialize();
        }
    }
}