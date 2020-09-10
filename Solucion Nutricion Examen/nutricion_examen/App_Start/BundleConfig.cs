using System.Web;
using System.Web.Optimization;

namespace nutricion_examen
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Content/plugins/jquery/jquery.min.js",
                      "~/Content/plugins/jquery-ui/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //Referencias de Bootstrap en lo que son los js
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                   
                      "~/Content/plugins/chart.js/Chart.min.js",
                      "~/Content/plugins/sparklines/sparkline.js",
                      "~/Content/plugins/jqvmap/jquery.vmap.min.js",
                      "~/Content/plugins/jqvmap/maps/jquery.vmap.usa.js",
                      "~/Content/plugins/jquery-knob/jquery.knob.min.js",
                      "~/Content/plugins/moment/moment.min.js",
                      "~/Content/plugins/daterangepicker/daterangepicker.js",
                      "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                      "~/Content/plugins/summernote/summernote-bs4.min.js",
                      "~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                      "~/Content/dist/js/adminlte.js",
                      "~/Content/dist/js/pages/dashboard.js",
                      "~/Content/dist/js/demo.js"));
            //referencia de Bootstrap en todo lo que es estilos css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/plugins/fontawesome-free/css/all.min.css",
                      "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                      "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                      "~/Content/plugins/jqvmap/jqvmap.min.css",
                      "~/Content/dist/css/adminlte.min.css",
                      "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                      "~/Content/plugins/daterangepicker/daterangepicker.css",
                      "~/Content/plugins/summernote/summernote-bs4.css",
                      "~/Content/alertifyjs/css/alertify.css"));
                      //"~/Content/css/Estilos2.css");
        }
    }
}
