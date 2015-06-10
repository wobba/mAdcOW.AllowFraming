using System.Web.UI.WebControls;
using Microsoft.SharePoint.WebControls;

namespace mAdcOW.AllowFraming
{
    [MdsCompliant(true)]
    public class InjectAllowFramingControl : WebControl
    {
        protected override void CreateChildControls()
        {
            Microsoft.SharePoint.WebPartPages.AllowFraming allowFraming =
                new Microsoft.SharePoint.WebPartPages.AllowFraming();
            this.Controls.Add(allowFraming);
        }
    }
}