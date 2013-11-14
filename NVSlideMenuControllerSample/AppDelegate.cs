//
//  NVSlideMenuController-Xamarin
//  AppDelegate.cs
//
//  Author:
//       Nicolas VERINAUD <nicolas@chloro.eu>
//
//  Copyright (c) 2013 Chlorophyll Vision. All Rights Reserved.
//
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using NVSlideMenuControllerLib;

namespace NVSlideMenuControllerSample
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			UITableViewController tableVC = new UITableViewController(UITableViewStyle.Plain);
			UINavigationController navController = new UINavigationController(new MyViewController());
			NVSlideMenuController slideMenuController = new NVSlideMenuController(tableVC, navController);

			window = new UIWindow(UIScreen.MainScreen.Bounds);
			window.RootViewController = slideMenuController;
			window.MakeKeyAndVisible();
			
			return true;
		}
	}
}

