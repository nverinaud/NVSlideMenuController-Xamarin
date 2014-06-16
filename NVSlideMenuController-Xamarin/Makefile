MDTOOL ?= /Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool

all:
	$(MDTOOL) build -c:NuGet ./NVSlideMenuController-Xamarin.sln
	nuget pack NuGet/NVSlideMenuController/NVSlideMenuController.nuspec -o NuGet/NVSlideMenuController/

clean:
	$(MDTOOL) build -t:Clean -c:NuGet ./NVSlideMenuController-Xamarin.sln
