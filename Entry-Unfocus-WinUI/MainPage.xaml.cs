namespace HelloMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new NavPage());
    }

    private void entry_Focused(object sender, FocusEventArgs e)
    {
        this.log.Text += "Focused" + Environment.NewLine;
    }

    private void entry_Unfocused(object sender, FocusEventArgs e)
    {
        this.log.Text += "Unfocused" + Environment.NewLine;
    }

    private void entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (this.entry.Text.ToLower() == "unfocus")
        {
            this.entry.Unfocus();
        }
    }

    class NavPage : ContentPage
    {
        public NavPage()
        {
            var lb = new Label();
            lb.HorizontalTextAlignment = Microsoft.Maui.TextAlignment.Center;
            lb.VerticalTextAlignment = Microsoft.Maui.TextAlignment.Center;
            lb.FontSize = 18;
            lb.Text = "Empty Page. Navigate back.";

            this.Content = lb;
        }
    }
}