using System;

namespace PageObjects.Interfaces
{
    public interface IWebPageFactory
    {
        T Get<T>() where T : IWebPage, new();
        T Get<T>(TimeSpan customWait) where T : IWebPage, new();
    }
}
