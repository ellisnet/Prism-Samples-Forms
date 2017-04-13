# Prism Samples Forms
Samples that demonstrate how to use various Prism features with Xamarin.Forms.

| Solution | Description |
-----------|-------------|
| [UsingCompositeCommands][1] |How to use CompositeCommands to invoke commands in multiple unrelated ViewModels from a single interaction.
| [UsingDependencyService][2] |How to use Prism to auto inject platform specific dependencies that are registered with Xamarin.Forms DependencyService.
| [UsingPageDialogService][3] |How to use the IPageDialogService to display alerts and action sheets from within your ViewModels.
| [UsingModules][4] |How to use Prism modularization to separate the application logic using IModule, IModuleManager, ModuleCatalog.
| [ContosoCookbook][5] |Contoso Cookbook is a classic Microsoft sample recipe app; first adapted for Xamarin.Forms by Jeff Prosise in 2015 and now updated to use Prism for Xamarin.Forms. Demonstrates how to use a TabbedPage with a DataTemplate for the tabs, and a ListView with DataTemplate for the recipe list on each tab; for a clean professional-looking UI.
| VS2017MasterDetailPclWithoutAzure (Autofac only) |This is the Visual Studio 2017 Xamarin.Forms Master Detail template application (with PCL - not Shared Library, and no Azure Host) created via File &gt; New Project - but updated to be a Prism application. Search the code for the string "PRISM-CONVERSION-NOTE:" for notes about what was changed to turn the VS2017-generated app into a Prism app.
| HamburgerMenu (Autofac only) |Sample app from Dan Siegel that demonstrates how to create an app with an appearing/disappearing left-side drawer for selecting views - accessed via a typical "hamburger" menu icon. Also demonstrates how to implement a logon screen, with a logout option in the toolbar. (Tip: If you are wondering how to logon, read the code carefully.)
| TabbedNavigation (Autofac only) |Sample app from Dan Siegel that demonstrates various techniques for creating a tabbed page and navigating to the different tabs.  Includes a demonstration of a dynamically generated tabbed page, where the tabs are specified at runtime (including by the user).
| [Autofac_6.3.0][6] (folder) |This folder contains all of the samples listed above, updated to use Autofac for Prism for Xamarin.Forms version 6.3.0. A few roadblocks were encountered when attempting to convert these samples from using Unity to using Autofac, and not all sample functionality is working. Comments have been added to the code where appropriate.
| [Autofac_New][7] (folder) |This folder contains all of the samples listed above, updated to work with Autofac for Prism for Xamarin.Forms as updated in [Prism Pull Request # 1017](https://github.com/PrismLibrary/Prism/pull/1017). These samples use Autofac version 3.5.2, because Autofac 4.x has been switched to be a .NetStandard library. The samples have been tested thoroughly and all functionality appears to be working - on iOS, Android and UWP.
| [Autofac_NetStandard][8] (folder) |This folder contains all of the samples listed above, updated to work with Autofac for Prism for Xamarin.Forms as updated in [Prism Pull Request # 1017](https://github.com/PrismLibrary/Prism/pull/1017) and updated to be .NetStandard projects as described by [Oren Novotny](https://oren.codes/2016/07/09/using-xamarin-forms-with-net-standard/). These samples use the latest version of Autofac (currently version 4.5.0) which has been updated to be a .NetStandard library. The samples have been tested thoroughly and all functionality appears to be working - on iOS, Android and UWP.


[1]: UsingCompositeCommands/
[2]: UsingDependencyService/
[3]: UsingPageDialogService/
[4]: UsingModules/
[5]: ContosoCookbook/
[6]: Autofac_6.3.0/
[7]: Autofac_New/
[8]: Autofac_NetStandard/
