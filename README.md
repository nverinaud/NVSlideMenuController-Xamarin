# NVSlideMenuController Xamarin

Wrapper to the [NVSlideMenuController](https://github.com/nverinaud/NVSlideMenuController) library for Xamarin.iOS.

## Guide

### Using the UIViewController's callbacks

Due to C# class extension mechanism you can't override the callbacks in your `UIViewController`'s subclasses.

To implement the callback you should follow the following pattern :

```csharp
public partial class MyViewController : UIViewController
{
	public MyViewController() : base("MyViewController", null)
	{
	}

	[Export ("viewWillSlideIn:inSlideMenuController:")] // This statement is mandatory !!
	public void ViewWillSlideIn(bool animated, NVSlideMenuController slideMenuController)
	{
	}

	[Export ("viewDidSlideIn:inSlideMenuController:")] // This statement is mandatory !!
	public void ViewDidSlideIn(bool animated, NVSlideMenuController slideMenuController)
	{
	}

	[Export ("viewWillSlideOut:inSlideMenuController:")] // This statement is mandatory !!
	public void ViewWillSlideOut(bool animated, NVSlideMenuController slideMenuController)
	{
	}

	[Export ("viewDidSlideOut:inSlideMenuController:")] // This statement is mandatory !!
	public void ViewDidSlideOut(bool animated, NVSlideMenuController slideMenuController)
	{
	}
}
```

## Author

Nicolas VERINAUD ([@nverinaud](https://twitter.com/nverinaud))

## License

Released under the MIT License. For more see `LICENSE.md`.