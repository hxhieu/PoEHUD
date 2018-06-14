using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoeHUD.Hud.Health
{
    public class AutoPotSettings : SettingsBase
    {
        public AutoPotSettings()
        {
            Enable = true;
            Test = new HotkeyNode(Keys.D1);
            Test.OnValueChanged = () =>
            {
                DebugPlug.DebugPlugin.LogMsg("AAAA", 1000);
            };
        }

        [Menu("Hotyey")]
        public HotkeyNode Test { get; set; }
    }
}
