using AutomationFramework.Config.Enums;
using AutomationFramework.SamplePages.Pages;
using AutomationFramework.UiTesting;
using NUnit.Framework;
using Shouldly;
using System.Collections.Generic;

namespace AutomationFramework.SampleTestsNetCore
{
    [TestFixture, Parallelizable]
    public class MultiBrowserHomePageTests : MultiBrowserUiTest
    {
        private static IList<Browser> _browsers;

        [SetUp]
        public void SetBrowsers()
        {
            _browsers = new List<Browser>(Config.TargetBrowsers);
        }

        [TestCaseSource(nameof(_browsers))]
        public void CheckHomePageForText(Browser browser)
        {
            SetupDriver(browser);

            var page = Factory.Get<HomePage>();

            page
                .CheckPageForText("A better way to work together")
                .ShouldBeTrue();
        }
    }
}
