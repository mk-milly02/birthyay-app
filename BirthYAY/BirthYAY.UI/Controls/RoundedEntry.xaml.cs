namespace BirthYAY.UI.Controls;

public partial class RoundedEntry : ContentView
{
    public RoundedEntry()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty IsPasswordProperty =
        BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(RoundedEntry), default(bool));

    public bool IsPassword
    {
        get => (bool)GetValue(IsPasswordProperty);
        set => SetValue(IsPasswordProperty, value);
    }

    public static readonly BindableProperty KeyboardProperty =
        BindableProperty.Create(nameof(Keyboard), typeof(Keyboard), typeof(RoundedEntry), Keyboard.Default);

    public Keyboard Keyboard
    {
        get => (Keyboard)GetValue(KeyboardProperty);
        set => SetValue(KeyboardProperty, value);
    }

    public static readonly BindableProperty PlaceholderProperty =
        BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(RoundedEntry), default(string));

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(RoundedEntry), default(string), BindingMode.TwoWay);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    private void PART_Entry_Focused(object sender, FocusEventArgs e)
    {
        if (PART_Entry.IsFocused)
        {
            PART_Border.BackgroundColor = Color.FromArgb("#F3F2F1");
            PART_Border.StrokeThickness = 1.5;
        }
        else
        {
            PART_Border.Background = Color.FromArgb("#C8C8C8");
            PART_Border.StrokeThickness = 0;
        }
    }
}