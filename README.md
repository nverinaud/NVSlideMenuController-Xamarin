# NVSlideMenuController Xamarin

Wrapper around the [NVSlideMenuController](https://github.com/nverinaud/NVSlideMenuController) library for Xamarin.iOS.

## Guide

### Installation

#### Using NuGet

* A NuGet package is available in nuget.org. Simply search for `NVSlideMenuController`.

#### Downloading the DLL

* The DLL is released using Github Release. Follow [this link](https://github.com/nverinaud/NVSlideMenuController/releases) to find the version you want.

#### Building the DLL

1. Open the `NVSlideMenuController-Xamarin.sln` solution.
2. Build in Release (or Debug if you want the symbolication).
3. Copy the created DLL in the `NVSlideMenuController-Xamarin/bin/{Debug|Release}` folder to your project.
4. You're done !

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

### Building your own nuget copy

1. Move into `NVSlideMenuController-Xamarin` folder.
2. Update `NuGet/NVSlideMenuController/NVSlideMenuController.nuspec` if you want.
3. Run `make`.
4. Your package is created in `NVSlideMenuController-Xamarin/NuGet/NVSlideMenuController/{*}.nupkg`.

## Author

Nicolas VERINAUD ([@nverinaud](https://twitter.com/nverinaud))

## License

Released under the MIT License. For more see `LICENSE.md`.