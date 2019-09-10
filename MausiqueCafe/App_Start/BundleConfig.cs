using System.Web;
using System.Web.Optimization;

namespace MausiqueCafe
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/web/styles/bootstrap4/popper.js",
                         "~/Content/web/styles/bootstrap4/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/otherJS").Include(
                 "~/Content/web/plugins/OwlCarousel2-2.2.1/owl.carousel.js",
                 "~/Content/web/plugins/parallax-js-master/parallax.min.js",
                 "~/Content/web/js/custom.js",
                 "~/Content/web/engine1/wowslider.js",
                 "~/Content/web/engine1/script.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/web/styles/bootstrap4/bootstrap.min.css",
                      "~/Content/web/styles/main_styles.css",
                      "~/Content/web/styles/responsive.css",
                      "~/Content/web/engine1/style.css",
                      "~/Content/web/plugins/font-awesome-4.7.0/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/OwlCarousel2").Include(
                    "~/Content/web/plugins/OwlCarousel2-2.2.1/owl.carousel.css",
                    "~/Content/web/plugins/OwlCarousel2-2.2.1/owl.theme.default.css",
                    "~/Content/web/plugins/OwlCarousel2-2.2.1/animate.css"));
        }
    }
}
