namespace VeroniqueTest;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		SetEntryBorderFocus(Email, EmailBorder, EmailImage, "user_focus.png", "user.png");
		SetEntryBorderFocus(Password, PasswordBorder, PasswordImage, "key_focus.png", "key.png");
	}

    private static void SetEntryBorderFocus(Entry entry, Border border, Image image, string focusImageSource, string simpleImageSource)
	{
		entry.Focused += delegate
		{
			border.Stroke = entry.TextColor = Color.FromArgb("#E78F23");
            image.Source = ImageSource.FromFile(focusImageSource);
            border.StrokeThickness = 2.5;
		};

		entry.Unfocused += delegate
		{
            border.StrokeThickness = 1;
            border.Stroke =  entry.TextColor = Colors.White;
			image.Source = ImageSource.FromFile(simpleImageSource);
        };
	}

}

