using Kentico.PageBuilder.Web.Mvc;
using System.Web.Mvc;
using VisualAntidote.AddThisWidget.Kentico.MVC.Controllers;
using VisualAntidote.AddThisWidget.Kentico.MVC.Models;

[assembly: RegisterWidget("VisualAntidote.AddThisWidget", typeof(AddThisController), "Add This", IconClass = "icon-bubbles")]
namespace VisualAntidote.AddThisWidget.Kentico.MVC.Controllers
{
    public class AddThisController : WidgetController<AddThisWidgetProperties>
    {
        public AddThisController()
        {
        }

        public AddThisController(IWidgetPropertiesRetriever<AddThisWidgetProperties> propertiesRetriever,
                                        ICurrentPageRetriever currentPageRetriever) : base(propertiesRetriever, currentPageRetriever)
        {
        }

        public ActionResult Index()
        {
            var properties = GetProperties();

            return PartialView("Widgets/_AddThisWidget", new AddThisWidgetViewModel
            {
                EmailBodyText = properties.EmailBodyText,
            });
        }
    }
}
