using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using RayMueller.Data;
using RayMueller.Models;

namespace RayMueller.Rules
{
	public partial class WOCLISTBusinessRules : RayMueller.Data.BusinessRules
    {
        
        /// <summary>
        /// Rule "WocClientlastname_Converter" implementation:
        /// This method will execute in any view before an action
        /// with a command name that matches "Insert|Update".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(WOCLISTModel instance)
        {
            // dropped
        }
    }
}
