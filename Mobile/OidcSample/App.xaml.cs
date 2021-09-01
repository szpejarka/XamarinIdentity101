using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OidcSample
{
    public partial class App : Application
    {
        // oidcxamarin101:/authenticated
        //public const string CallbackUri = "oidcxamarin101";
        //public static readonly string CallbackScheme = $"{CallbackUri}:/authenticated";
        //public static readonly string SignoutCallbackScheme = $"{CallbackUri}:/signout-callback-oidc";
        //public const string AuthorityUrl = "https://xamarinoidc-app.azurewebsites.net";
        //public const string ClientId = "gnabbermobileclient";
        //public const string Scope = "openid profile offline_access";

        public const string CallbackUri = "ssg-agility-engineer";
        public static string CallbackScheme = $"{CallbackUri}://signin-callback";
        public static string SignoutCallbackScheme = $"{CallbackUri}://signout-callback";
        public static string AuthorityUrl = "https://ssgidentity.azurewebsites.net";
        public static string ClientId = "ssg-agility-engineer-jacek";
        public static string Scope = "openid profile email ssg-agility-api offline_access";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
