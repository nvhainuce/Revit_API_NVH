using Autodesk.Revit.UI;
using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace REVIT_API_TUTORIAL_NVH
{
    public class ExternalApplication : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            //Create The Plugin Tab.
            application.CreateRibbonTab("Revit API Tutorial");

            #region Load the file path
            //Create The Plugin Panel.
            RibbonPanel Panel = application.CreateRibbonPanel("Revit API Tutorial", "Filtering");
            Assembly assembly = Assembly.GetExecutingAssembly();

            //Create The Plugin Button.
            PushButtonData Button4 = new PushButtonData("btn_Loc1", "Get all Walls", assembly.Location, "REVIT_API_TUTORIAL_NVH.Cmd_GetAllWalls");
            PushButton pushButton4 = Panel.AddItem(Button4) as PushButton;

            Uri UriPath4 = new Uri("pack://application:,,,/REVIT_API_TUTORIAL_NVH;component/PluginIcons/LoadFile.png");
            BitmapImage Image4 = new BitmapImage(UriPath4);
            pushButton4.LargeImage = Image4;
            #endregion

            #region Create The Grids
            

            //Create The Plugin Button.

            PushButtonData Button1 = new PushButtonData("Button1", "Draw Grids", assembly.Location, "REVIT_API_TUTORIAL_NVH.CreateGrids");
            PushButton pushButton1 = Panel.AddItem(Button1) as PushButton;

            Uri UriPath1 = new Uri("pack://application:,,,/REVIT_API_TUTORIAL_NVH;component/PluginIcons/Grids.png");
            BitmapImage Image1 = new BitmapImage(UriPath1);
            pushButton1.LargeImage = Image1;
            #endregion

            #region Create The Floor
            //Create The Plugin Button.
            PushButtonData Button3 = new PushButtonData("Button3", "Draw Floors", assembly.Location, "REVIT_API_TUTORIAL_NVH.CreateFloor");
            PushButton pushButton3 = Panel.AddItem(Button3) as PushButton;

            Uri UriPath3 = new Uri("pack://application:,,,/REVIT_API_TUTORIAL_NVH;component/PluginIcons/Floors.png");
            BitmapImage Image3 = new BitmapImage(UriPath3);
            pushButton3.LargeImage = Image3;
            #endregion 

            return Result.Succeeded;
        }
    }
}
