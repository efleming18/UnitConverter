using System.Web.Optimization;

namespace UI.AppStart {
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/Styles/css").Include("~/Styles/site.css"));
            bundles.Add(new StyleBundle("~/Styles/Mobile/css").Include("~/Styles/Mobile/site.css"));
        }
    }
}