using Shouldly;
using NUnit.Framework;
using AutomationFramework.UiTesting;
using AutomationFramework.SamplePages.Pages;

namespace AutomationFramework.SampleTestsNetCore
{
    [TestFixture, Parallelizable]
    public class HomePageTests : UiTest
    {
        [Test]
        public void CheckHomePageForText()
        {
            var page = Factory.Get<HomePage>();

            page
                .CheckPageForText("A better way to work together")
                .ShouldBeTrue();
        }

        [Test]
        public void NavigateToFeaturesPage()
        {
            var page = Factory.Get<HomePage>();

            page
                .ClickFeaturesLink()
                .CheckPageForText("Seamless code review")
                .ShouldBeTrue();
        }

        [Test]
        public void NavigateToBusinessPage()
        {
            var page = Factory.Get<HomePage>();

            page
                .ClickBusinessLink()
                .CheckPageForText("A smarter way to work together")
                .ShouldBeTrue();
        }

        [Test]
        public void NavigateToExplorePage()
        {
            var page = Factory.Get<HomePage>();

            page
                .ClickExploreLink()
                .CheckPageForText("Want Explore delivered to your inbox?")
                .ShouldBeTrue();
        }

        [Test]
        public void NavigateToMarketplacePage()
        {
            var page = Factory.Get<HomePage>();

            page
                .ClickMarketplaceLink()
                .CheckPageForText("Apps with free trials")
                .ShouldBeTrue();
        }

        [Test]
        public void NavigateToPricingPage()
        {
            var page = Factory.Get<HomePage>();

            page
                .ClickPricingLink()
                .CheckPageForText("Plans for all workflows")
                .ShouldBeTrue();
        }
    }
}
