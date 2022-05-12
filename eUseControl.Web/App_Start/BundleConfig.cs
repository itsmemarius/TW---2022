using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bootstrap.css
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/ContentMy/bootstrap.min.css", new CssRewriteUrlTransform()));

            //style.css
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                "~/ContentMy/style.css", new CssRewriteUrlTransform()));

            // materialdesignicons.css
            bundles.Add(new StyleBundle("~/bundles/materialdesignicons/css").Include(
                "~/ContentMy/materialdesignicons.min.css", new CssRewriteUrlTransform()));

            // pe-icon-7-stroke.css
            bundles.Add(new StyleBundle("~/bundles/peicon7/css").Include(
                 "~/ContentMy/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));


            //bootstrap.bundle.min
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                "~/ScriptsMy/bootstrap.bundle.min.js", new CssRewriteUrlTransform()));

            //app.js
            bundles.Add(new ScriptBundle("~/bundles/app/js").Include(
                "~/ScriptsMy/app.js", new CssRewriteUrlTransform()));

            //counter.init.js
            bundles.Add(new ScriptBundle("~/bundles/counter-init/js").Include(
                "~/ScriptsMy/counter.init.js", new CssRewriteUrlTransform()));

            //jquery.easing.min.js
            bundles.Add(new ScriptBundle("~/bundles/easing-min/js").Include(
                "~/ScriptsMy/easing.min.js", new CssRewriteUrlTransform()));

            //jquery.min.js
            bundles.Add(new ScriptBundle("~/bundles/jquery-min/js").Include(
                "~/ScriptsMy/jquery.min.js", new CssRewriteUrlTransform()));

            //scrollspy.min.js
            bundles.Add(new ScriptBundle("~/bundles/scrollspy-min/js").Include(
                "~/ScriptsMy/scrollspy.min.js", new CssRewriteUrlTransform()));


        }
    }
}