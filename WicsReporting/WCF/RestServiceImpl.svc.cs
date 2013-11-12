using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WicsReporting.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImpl" in code, svc and config file together.

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)] 
    public class RestServiceImpl : IRestServiceImpl
    {
        #region IRestService Members
        public string XMLData(string id)
        {
            return "You Request Porduct" + ":" + id;

        }
        public string JSONData(string id)
        {
            return "Yor Request Product" + ":" + id;
        }
        #endregion
    }
}
