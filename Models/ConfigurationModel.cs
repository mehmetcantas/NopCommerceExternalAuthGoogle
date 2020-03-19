using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.ExternalAuth.Google.Models
{
  public class ConfigurationModel: BaseNopModel
  {
    [NopResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientKeyIdentifier")]
    public string ClientId { get; set; }

    [NopResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientSecret")]
    public string ClientSecret { get; set; }
  }
}