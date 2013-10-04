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
			UIViewController innerVC = new UIViewController();
			UINavigationController navController = new UINavigationController(innerVC);
			NVSlideMenuController slideMenuController = new NVSlideMenuController(tableVC, navController);

			innerVC.NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.FastForward);
			innerVC.NavigationItem.LeftBarButtonItem.Clicked += delegate (object sender, EventArgs e) {
				slideMenuController.ToggleMenuAnimated((NSObject)sender);
			};
			innerVC.Title = "Slide Menu";
			innerVC.View.BackgroundColor = UIColor.White;

			window = new UIWindow(UIScreen.MainScreen.Bounds);
			window.RootViewController = slideMenuController;
			window.MakeKeyAndVisible();
			
			return true;
		}
	}
}
