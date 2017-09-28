using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using RayMueller.Data;

namespace RayMueller.Rules
{
	public partial class WOCLISTBusinessRules : RayMueller.Data.BusinessRules
    {
        
        [ControllerAction("WOCLIST", "Calculate", "WocClientlastname")]
        public void CalculateWOCLIST(
                    int? wocRecIdpk, 
                    DateTime? wocCreateddate, 
                    DateTime? wocUpdatedon, 
                    string wocClientlastname, 
                    string wocClientfirstname, 
                    string wocClientcin, 
                    DateTime? wocClientconsentdate, 
                    DateTime? wocReceiveddate, 
                    DateTime? wocCompleteddate, 
                    int? wocCurrentstatusfk, 
                    string wocCurrentstatusfkrefwocStatusname, 
                    string wocPerformedby, 
                    string wocComments, 
                    string wocSeqid, 
                    float? wocActiontrackingid, 
                    int? wocRequesthhcmafk, 
                    string wocRequesthhcmafkhhcmaname, 
                    int? wocTargethhcmafk, 
                    string wocTargethhcmafkhhcmaname)
        {
            UpdateFieldValue("WocClientlastname", !String.IsNullOrEmpty(wocClientlastname) ? wocClientlastname.ToUpper() : String.Empty);
        }
    }
}
