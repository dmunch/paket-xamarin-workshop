# Workshop paket and Xamarin

Example Xamarin.Forms project which demonstrates the conversion of an existing Xamarin.Forms app from NuGet packet management
to [paket](https://github.com/fsprojects/Paket).

A good introduction to paket can be found [here](http://forki.github.io/PaketIntro/#/).

In order to demonstrate the capabilities and usefulness of paket, the project uses a particular project layout and several dependencies 
a vanilla Xamarin.Forms project wouldn't use. ViewModels and Views are split out into different PCL projects. Using [PRISM](https://github.com/PrismLibrary/Prism) this also allows us having a project with ViewModels without any dependencies on Xamarin.Forms.

The [master](https://github.com/dmunch/paket-xamarin-workshop) branch contains the solution before transition to paket. The [paket](https://github.com/dmunch/paket-xamarin-workshop/tree/paket) branch contains
all the necessary steps for converting the solution to paket.

