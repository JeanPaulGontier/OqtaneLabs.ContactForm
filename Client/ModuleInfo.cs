using Oqtane.Models;
using Oqtane.Modules;

namespace OqtaneLabs.ContactForm
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Contact Form",
            Description = "Contact Form",
            Version = "10.0.0",
            Dependencies = "OqtaneLabs.ContactForm.Shared.Oqtane",
            SettingsType = "OqtaneLabs.ContactForm.Settings, OqtaneLabs.ContactForm.Client.Oqtane",
            PackageName = "OqtaneLabs.ContactForm"
        };
    }
}
