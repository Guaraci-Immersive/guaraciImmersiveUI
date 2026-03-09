using CommunityToolkit.Maui.Markup;

namespace GuaraciImmersive.Views;

public class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        BackgroundColor = Colors.White;

        Content = new VerticalStackLayout
        {
            Spacing = 20,
            Padding = 30,
            Children =
            {
                new Label { Text = "Painel Principal", FontSize = 24, FontAttributes = FontAttributes.Bold}.CenterHorizontal(),
                new Label { Text = "Métricas", FontSize = 16}.CenterHorizontal()
            }
        }.CenterVertical();
    }
}