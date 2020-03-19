﻿namespace Nop.Plugin.ExternalAuth.Google
{
  public class GoogleAuthenticationDefaults
  {
    /// <summary>
    /// Gets a name of the view component to display login button
    /// </summary>
    public const string VIEW_COMPONENT_NAME = "GoogleAuthentication";

    /// <summary>
    /// Gets a plugin system name
    /// </summary>
    public static string SystemName = "ExternalAuth.Google";

    /// <summary>
    /// Gets a name of error callback method
    /// </summary>
    public static string ErrorCallback = "ErrorCallback";
  }
}