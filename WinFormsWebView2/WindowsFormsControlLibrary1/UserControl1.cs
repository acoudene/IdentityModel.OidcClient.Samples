using IdentityModel.OidcClient;
using System.Text;
using System;
using System.Windows.Forms;
using WinFormsWebView2;

namespace WindowsFormsControlLibrary1
{
  public partial class UserControl1 : UserControl
  {
    private OidcClient _oidcClient;

    private async void Login()
    {
      LoginResult loginResult;

      try
      {
        loginResult = await _oidcClient.LoginAsync();
      }
      catch (Exception exception)
      {
        Output.Text = $"Unexpected Error: {exception.Message}";
        return;
      }


      if (loginResult.IsError)
      {
        MessageBox.Show(this, loginResult.Error, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        var sb = new StringBuilder(128);
        foreach (var claim in loginResult.User.Claims)
        {
          sb.AppendLine($"{claim.Type}: {claim.Value}");
        }

        if (!string.IsNullOrWhiteSpace(loginResult.RefreshToken))
        {
          sb.AppendLine();
          sb.AppendLine($"refresh token: {loginResult.RefreshToken}");
        }

        if (!string.IsNullOrWhiteSpace(loginResult.IdentityToken))
        {
          sb.AppendLine();
          sb.AppendLine($"identity token: {loginResult.IdentityToken}");
        }

        if (!string.IsNullOrWhiteSpace(loginResult.AccessToken))
        {
          sb.AppendLine();
          sb.AppendLine($"access token: {loginResult.AccessToken}");
        }

        Output.Text = sb.ToString();
      }
    }


    public UserControl1()
    {
      InitializeComponent();

      var options = new OidcClientOptions
      {
        Authority = "https://tdkeycloak.azurewebsites.net/auth/realms/Technidata",
        ClientId = "tdnexlabs",
        Scope = "openid profile email",
        RedirectUri = "http://127.0.0.1/sample-wpf-app",
        Browser = new WinFormsWebView()
      };

      _oidcClient = new OidcClient(options);

      Login();
    }
  }
}
