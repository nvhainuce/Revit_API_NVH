using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using Autodesk.Revit.Attributes;

namespace REVIT_API_TUTORIAL_NVH
{
    [TransactionAttribute(TransactionMode.Manual)]
    class CreateFloor : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                #region UIDocument and Document     
                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                Document doc = uidoc.Document;
                #endregion


                return Result.Succeeded;
            }
            catch(Exception e)
            {
                return Result.Failed;
            }
            
        }
       
    }
}
