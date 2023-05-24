using Android.Widget;

namespace VeroniqueTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
#if ANDROID
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("DeleteTextunderline", (handler, view) =>
        {
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            //handler.PlatformView.SetHintTextColor(Android.Graphics.Color.Rgb(67, 183, 140));  
            EditText nativeEditText = handler.PlatformView;
#pragma warning disable CA1416 // Valider la compatibilité de la plateforme
#pragma warning restore CA1416 // Valider la compatibilité de la plateforme
        });
#endif
    }
}
