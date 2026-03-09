using System.Net.Http.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GuaraciImmersive.ViewModels;

public partial class  LoginViewModel : ObservableObject
{
    private readonly HttpClient _httpClient = new();

    [ObservableProperty]
    private string email;

    [ObservableProperty]
    private string password;

    [RelayCommand]
    private async Task LoginAsync()
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(password))
        {
            await Application.Current.MainPage.DisplayAlert("Aviso", "Por favor, preencha todos os campos.", "OK");
            return;
        }

        try
        {
            var loginData = new { email = email, password = password };
            var response = await _httpClient.PostAsJsonAsync("http://localhost:8000/api/metaquest/login", loginData);

            if (response.IsSuccessStatusCode)
            {
                await Shell.Current.GoToAsync(" DashboardPage");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Erro", "Falha no login. Verifique suas credenciais.", "OK");
            }
        }catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Erro de conexão", ex.Message, "OK");
        }

    }
}
