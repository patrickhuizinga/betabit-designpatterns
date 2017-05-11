using System.Collections.Generic;

namespace BetaBit.DesignPatterns
{
    public abstract class PageViewModelBase
    {
        protected ContainerViewModel Container { get; }
        protected Data Data => Container.Data;
        protected ISearchContext SearchContext
        {
            get { return Data.SearchContext; }
            set { Data.SearchContext = value; }
        }

        public List<string> Items
        {
            get { return Data.Items; }
            set { Data.Items = value; }
        }

        protected PageViewModelBase(ContainerViewModel container)
        {
            Container = container;
        }

        public string Title => SearchContext.Title;
    }
}
