﻿using AutomationFramework.PageObjects.Interfaces;

namespace AutomationFramework.SamplePages.Interfaces
{
    public interface IPricing : IBanner, IWebPage
    {
        IContactUs ClickContactUsLink();
    }
}
