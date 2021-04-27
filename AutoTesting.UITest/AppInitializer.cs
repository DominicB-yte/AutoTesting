﻿using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace AutoTesting.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                    .InstalledApp("com.companyname.autotesting")
                    .EnableLocalScreenshots()
                    .StartApp();
            }
            else { return ConfigureApp.iOS.StartApp(); }
        }
    }
}