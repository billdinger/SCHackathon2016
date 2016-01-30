﻿namespace Sitecore.Feature.Blog.Controllers
{
    using System;
    using System.Web.Mvc;
    using Sitecore.Feature.Blog.CMS.Contexts;
    using Sitecore.Feature.Blog.CMS.Log;
    using Sitecore.Feature.Blog.Domain.Templates;

    public class BlogController : Controller
    {
        private readonly IContext _context;
        private IContext Context { get { return _context; } }

        private readonly IRenderingContext _renderingContext;
        private IRenderingContext RenderingContext { get { return _renderingContext; } }

        private readonly ILogger _logger;
        private ILogger Logger { get { return _logger; } }

        public BlogController(IContext context, IRenderingContext renderingContext, ILogger logger)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (renderingContext == null)
            {
                throw new ArgumentNullException("renderingContext");
            }
            if (logger == null)
            {
                throw new ArgumentNullException("logger");
            }
            _logger = logger;
            _context = context;
            _renderingContext = renderingContext;
        }

        public ActionResult Index()
        {
            // 1.) Retrieve our current item from our context.
            var listing = Context.GetCurrentItem<IBlogListing>();
            if (listing == null)
            {
                // TODO throw exception!
            }

            // 2.) get our rendering parameters
            var parameters = RenderingContext.GetRenderingParameters<IBlogRenderingParameters>();
            if (parameters == null)
            {
                // TODO throw exceptions.
            }

            // 3.) Create our view.

            // 4.) Return our controller.

            throw new NotImplementedException();
        }

        public ActionResult BlogDetail()
        {
            throw new NotImplementedException();
        }
    }
}