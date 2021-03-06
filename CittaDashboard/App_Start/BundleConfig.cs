﻿using System.Web;
using System.Web.Optimization;

namespace CittaDashboard
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
                      "~/Scripts/vendor/jquery/jquery.min.js",
                      "~/Scripts/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Scripts/vendor/jquery-easing/jquery.easing.min.js",
                      "~/Scripts/vendor/chart.js/Chart.min.js",
                      "~/Scripts/vendor/datatables/jquery.dataTables.js",
                      "~/Scripts/vendor/datatables/dataTables.bootstrap4.js",
                      "~/Scripts/js/sb-admin.min.js",
                      "~/Scripts/js/demo/datatables-demo.js",
                      "~/Scripts/js/demo/chart-area-demo.js"));

            

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/vendor").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/vendor/datatables/dataTables.bootstrap4.css",
                      "~/Content/sb-admin.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/dashboard.css"));
        }
    }
}
