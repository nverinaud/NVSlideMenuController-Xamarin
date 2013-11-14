using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using NVSlideMenuControllerLib;

namespace NVSlideMenuControllerSample
{
	public partial class MyViewController : UIViewController
	{
		public MyViewController() : base("MyViewController", null)
		{
			NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.FastForward);
			NavigationItem.LeftBarButtonItem.Clicked += delegate (object sender, EventArgs e) {
				this.SlideMenuController().ToggleMenuAnimated((NSObject)sender);
			};

			Title = "Slide Menu";
		}

		[Export ("viewWillSlideIn:inSlideMenuController:")]
		public void ViewWillSlideIn(bool animated, NVSlideMenuController slideMenuController)
		{
			Console.WriteLine("Will slide in");
		}

		[Export ("viewDidSlideIn:inSlideMenuController:")]
		public void ViewDidSlideIn(bool animated, NVSlideMenuController slideMenuController)
		{
			Console.WriteLine("Did slide in");
		}

		[Export ("viewWillSlideOut:inSlideMenuController:")]
		public void ViewWillSlideOut(bool animated, NVSlideMenuController slideMenuController)
		{
			Console.WriteLine("Will slide out");
		}

		[Export ("viewDidSlideOut:inSlideMenuController:")]
		public void ViewDidSlideOut(bool animated, NVSlideMenuController slideMenuController)
		{
			Console.WriteLine("Did slide out");
		}
	}
}

