using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Shapes;
using GuaraciImmersive.ViewModels;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace GuaraciImmersive.Views;

public class LoginPage : ContentPage
{
    public LoginPage()
    {
        BackgroundColor = Color.FromArgb("#F0F2F5");
        BindingContext = new LoginViewModel();

        Content = new Grid
        {
            Children =
            {
                new Border
                {
                    StrokeShape = new RoundRectangle { CornerRadius = 15 },
                    StrokeThickness = 0,
                    BackgroundColor = Colors.White,
                    WidthRequest = 400,
                    HeightRequest = 550,
                    Shadow = new Shadow { Brush = Colors.Gray, Offset = new Point(0, 10), Opacity = 0.2f },

                    Content = new VerticalStackLayout
                    {
                        Spacing = 15,
                        Padding = 40,
                        Children =
                        {
                            new Image { Source = "foto_doutor.png", WidthRequest = 80, HeightRequest = 80 }.CenterHorizontal(),
                            new Label { Text = "Painel do Terapeuta", FontSize = 22, FontAttributes = FontAttributes.Bold }.CenterHorizontal(),
                            new Label { Text = "Acesso seguro", TextColor = Colors.Gray }.CenterHorizontal().Margin(new Microsoft.Maui.Thickness(0, 0, 0, 20)),

                            new Label { Text = "Email", FontAttributes = FontAttributes.Bold },
                            new Entry { Placeholder = "Digite seu email" }
                                .Bind(Entry.TextProperty, nameof(LoginViewModel.Email)),

                            new Label { Text = "Senha", FontAttributes = FontAttributes.Bold },
                            new Entry { IsPassword = true, Placeholder = "Digite sua senha" }
                                .Bind(Entry.TextProperty, nameof(LoginViewModel.Password)),

                            new Button
                            {
                                Text = "Acessar painel principal",
                                BackgroundColor = Color.FromArgb("#00796B"),
                                TextColor = Colors.White,
                                CornerRadius = 8,
                                HeightRequest = 45
                            }.Margin(new Microsoft.Maui.Thickness(0, 30, 0, 0))
                             .Bind(Button.CommandProperty, nameof(LoginViewModel.LoginCommand))
                        }
                    }
                }.CenterHorizontal().CenterVertical()
            }
        };
    }
}