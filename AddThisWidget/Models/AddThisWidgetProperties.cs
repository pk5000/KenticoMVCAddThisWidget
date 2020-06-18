using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace VisualAntidote.AddThisWidget.Kentico.MVC.Models
{
    public class AddThisWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Email Body Text")]
        public string EmailBodyText { get; set; } = "";
    }
}
