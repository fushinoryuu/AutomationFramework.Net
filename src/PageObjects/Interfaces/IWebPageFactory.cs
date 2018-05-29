namespace PageObjects.Interfaces
{
    public interface IWebPageFactory
    {
        T Get<T>() where T : IWebPage, new();
    }
}
