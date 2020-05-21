﻿using System.Net.Http.Formatting;
using Our.Umbraco.CompositionsViewer.PackageConstants;
using Umbraco.Core;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Mvc;
using Umbraco.Web.Trees;
using Umbraco.Web.WebApi.Filters;

namespace Our.Umbraco.CompositionsViewer.Controllers
{

    [Tree(Constants.Applications.Settings, CompositionViewerConstants.CompositionViewerTreeAlias, TreeTitle = CompositionViewerConstants.CompositionViewerTreeTitle, TreeGroup = Constants.Trees.Groups.ThirdParty, SortOrder = 5)]
    [UmbracoApplicationAuthorize(Constants.Applications.Settings)]
    [PluginController(CompositionViewerConstants.CompositionViewerPluginAreaName)]
    public class CompositionViewerTreeController : TreeController
    {
        protected override TreeNodeCollection GetTreeNodes(string id, FormDataCollection queryStrings)
        {
           return new TreeNodeCollection();
        }

        protected override MenuItemCollection GetMenuForNode(string id, FormDataCollection queryStrings)
        {
            return null;
        }

        protected override TreeNode CreateRootNode(FormDataCollection queryStrings)
        {
            var root = base.CreateRootNode(queryStrings);

            root.RoutePath = $"{Constants.Applications.Settings}/{CompositionViewerConstants.CompositionViewerTreeAlias}/view";
            root.Icon = "icon-help-alt";
            root.HasChildren = false;
            root.MenuUrl = null;

            return root;
        }
    }
}
