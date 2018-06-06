using Shouldly;
using NUnit.Framework;
using AutomationFramework.UiTesting;
using AutomationFramework.SamplePages.Pages;

namespace AutomationFramework.SampleTestsNetCore
{
    [TestFixture, Parallelizable]
    public class SetA : UiTest
    {
        [Test]
        public void CheckHomePageForText()
        {
            //var home = Factory.Get<HomePage>();

            //home.CheckPageForText("A better way to work together").ShouldBeTrue();
        }
    }
}
