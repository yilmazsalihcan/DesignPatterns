using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    enum ScreenType
    {
        Windows,
        Web,
        Mobile
    }

    /// <summary>
    /// Creator Class
    /// </summary>
    class ScreenCreator
    {
        /// <summary>
        /// Factory Method
        /// </summary>
        /// <param name="screenType">Ekran Tipi</param>
        /// <returns>Asıl ürünü taşıyan referans</returns>
        public IScreen ScreenFactory(ScreenType screenType)
        {
            IScreen screen = null;
            
            switch (screenType)
            {
                case ScreenType.Windows:
                    screen = new WinScreen();
                    break;
                case ScreenType.Web:
                    screen = new WebScreen();
                    break;
                case ScreenType.Mobile:
                    screen = new MobileScreen();
                    break;
            }

            return screen;
        }
    }
}
