using PoeHUD.Controllers;
using PoeHUD.Hud.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Hud.Health
{
    public class AutoPot : Plugin<AutoPotSettings>
    {
        public AutoPot(GameController gameController, Graphics graphics, AutoPotSettings settings) : base(gameController, graphics, settings) { }

        public override void Render()
        {
            Debug.WriteLine("HAHAH");
        }
    }
}
