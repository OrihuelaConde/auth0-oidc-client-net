﻿using static Android.App.Application;

namespace Auth0.OidcClient
{
    /// <summary>
    /// Primary class for performing authentication and authorization operations with Auth0 using the
    /// underlying <see cref="IdentityModel.OidcClient.OidcClient"/>.
    /// </summary>
    public class Auth0Client : Auth0ClientBase
    {
        /// <summary>
        /// Creates a new instance of the Auth0 OIDC Client.
        /// </summary>
        /// <param name="options">The <see cref="Auth0ClientOptions"/> specifying the configuration for the Auth0 OIDC Client.</param>
        public Auth0Client(Auth0ClientOptions options)
            : base(options, "xamarin-android")
        {
            options.Browser = options.Browser ?? new PlatformWebView();
            options.RedirectUri = $"{Context.PackageName}://{options.Domain}/android/{Context.PackageName}/callback".ToLower();
        }
    }
}