using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Hbys.UI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/Css").Include(
                "~/Content/css/style.default.css"));

            bundles.Add(new ScriptBundle("~/bundles/JS").Include(
                "~/Content/js/jquery-1.12.4.js",
                "~/Content/js/jquery-migrate-1.2.1.min.js",
                "~/Content/js/jquery-ui.js",
                "~/Content/js/bootstrap.min.js",
                "~/Content/js/modernizr.min.js",
                "~/Content/js/jquery.sparkline.min.js",
                "~/Content/js/toggles.min.js",
                "~/Content/js/retina.min.js",
                "~/Content/js/jquery.cookies.js",
                "~/Content/js/custom.js",
                "~/Content/js/datatables.min.js",
                "~/Content/js/waves.js",
                "~/Content/js/jquery.maskedinput.min.js",
                "~/Content/js/jquery.gritter.min.js",
                "~/Content/js/toastr.js",
                "~/Content/js/jquery.datetimepicker.js"));

           // BundleTable.EnableOptimizations = true;
        }
    }
}