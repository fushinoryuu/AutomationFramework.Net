using OpenQA.Selenium;
using AutomationFramework.PageObjects;
using AutomationFramework.SamplePages.Interfaces;

namespace AutomationFramework.SamplePages.Pages
{
    public class ContactUsPage : WebPage, IContactUs
    {
        #region WebElements

        protected IWebElement GitHubLogo => FindElementBy(By.ClassName("octicon"));

        #endregion

        #region Initializers

        public ContactUsPage()
        {
            WebElements.Add(GitHubLogo);
        }

        #endregion

        public IHome ClickGitHubLogo()
        {
            GitHubLogo.Click();

            return Factory.Get<HomePage>();
        }
    }
}
