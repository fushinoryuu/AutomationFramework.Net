using Driver.Interfaces;

namespace PageObjects.Interfaces
{
    public interface IWebPageFactory
    {
        IAutomationDriver Driver { get; set; }

        T Get<T>();
    }
}
