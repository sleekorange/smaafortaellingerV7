using System;
using Umbraco.Web.PublishedCache;
using System.Linq;
using umbraco;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web;
using System.Collections.Generic;

namespace SmaafortaellingerV7.Infrastructure.Helpers
{
    public class SiteHelpers
    {
        public static UmbracoHelper UmbracoHelper => new UmbracoHelper(UmbracoContext.Current);
        public static IPublishedContent RootNode => UmbracoHelper.TypedContent(UmbracoHelper.UmbracoContext.PageId).AncestorOrSelf(1);
        public static IPublishedContent Settings => RootNode.Children().FirstOrDefault(x => x.DocumentTypeAlias == "settings");
        public static ContextualPublishedMediaCache MediaCache { get { return UmbracoContext.Current.MediaCache; } }
        public static ContextualPublishedContentCache ContentCache { get { return UmbracoContext.Current.ContentCache; } }

        // Shortcuts to the most commonly used services
        public static IEntityService EntityService { get { return ApplicationContext.Current.Services.EntityService; } }
        public static IContentService ContentService { get { return ApplicationContext.Current.Services.ContentService; } }
        public static IMediaService MediaService { get { return ApplicationContext.Current.Services.MediaService; } }
        public static IContentTypeService ContentTypeService { get { return ApplicationContext.Current.Services.ContentTypeService; } }

        public static IUserService UserService
        {
            get { return ApplicationContext.Current.Services.UserService; }
        }
    }
}