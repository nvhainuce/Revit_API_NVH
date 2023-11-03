using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using Autodesk.Revit.Attributes;
using System.Collections.Generic;

namespace REVIT_API_TUTORIAL_NVH
{
    [TransactionAttribute(TransactionMode.Manual)]
    class Cmd_GetAllWalls : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                #region UIDocument and Document     
                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                Document doc = uidoc.Document;
                #endregion
                //goi ham get all walls
                GetAllWalls(doc);

                return Result.Succeeded;
            }
            catch (Exception e)
            {
                return Result.Failed;
            }

        }

        // Find all Wall instances in the document by using category filter
        public void GetAllWalls(Document document)
        {
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Walls);

            // Apply the filter to the elements in the active document
            // Use shortcut WhereElementIsNotElementType() to find wall instances only
            FilteredElementCollector collector = new FilteredElementCollector(document);
            IList<Element> walls = collector.WherePasses(filter).WhereElementIsNotElementType().ToElements();
            String prompt = "The walls in the current document are:\n";
            foreach (Element e in walls)
            {
                prompt += e.Name + e.Location + "\n";
            }

           
            TaskDialog.Show("Revit", prompt);
        }

    }
}
