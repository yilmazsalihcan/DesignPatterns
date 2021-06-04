using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Creational pattern grubundadır. 
             */

           ScreenCreator screenCreator = new ScreenCreator();
           IScreen screenWeb = screenCreator.ScreenFactory(ScreenType.Web);
           IScreen screenWindows =  screenCreator.ScreenFactory(ScreenType.Windows);
           IScreen screenMobile = screenCreator.ScreenFactory(ScreenType.Mobile);

            screenWindows.Draw();
            screenMobile.Draw();
            screenWeb.Draw();
        }
    }
}
