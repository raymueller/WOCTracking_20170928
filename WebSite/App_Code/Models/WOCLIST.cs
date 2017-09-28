using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using RayMueller.Data;

namespace RayMueller.Models
{
	public partial class WOCLISTModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _wocRecIdpk;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _wocCreateddate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _wocUpdatedon;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _wocClientlastname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _wocClientfirstname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _wocClientcin;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _wocClientconsentdate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _wocReceiveddate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _wocCompleteddate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _wocCurrentstatusfk;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _wocCurrentstatusfkrefwocStatusname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _wocPerformedby;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _wocComments;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _wocSeqid;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float? _wocActiontrackingid;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _wocRequesthhcmafk;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _wocRequesthhcmafkhhcmaname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _wocTargethhcmafk;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _wocTargethhcmafkhhcmaname;
        
        public WOCLISTModel()
        {
        }
        
        public WOCLISTModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? WocRecIdpk
        {
            get
            {
                return _wocRecIdpk;
            }
            set
            {
                _wocRecIdpk = value;
                UpdateFieldValue("WocRecIdpk", value);
            }
        }
        
        public DateTime? WocCreateddate
        {
            get
            {
                return _wocCreateddate;
            }
            set
            {
                _wocCreateddate = value;
                UpdateFieldValue("WocCreateddate", value);
            }
        }
        
        public DateTime? WocUpdatedon
        {
            get
            {
                return _wocUpdatedon;
            }
            set
            {
                _wocUpdatedon = value;
                UpdateFieldValue("WocUpdatedon", value);
            }
        }
        
        public string WocClientlastname
        {
            get
            {
                return _wocClientlastname;
            }
            set
            {
                _wocClientlastname = value;
                UpdateFieldValue("WocClientlastname", value);
            }
        }
        
        public string WocClientfirstname
        {
            get
            {
                return _wocClientfirstname;
            }
            set
            {
                _wocClientfirstname = value;
                UpdateFieldValue("WocClientfirstname", value);
            }
        }
        
        public string WocClientcin
        {
            get
            {
                return _wocClientcin;
            }
            set
            {
                _wocClientcin = value;
                UpdateFieldValue("WocClientcin", value);
            }
        }
        
        public DateTime? WocClientconsentdate
        {
            get
            {
                return _wocClientconsentdate;
            }
            set
            {
                _wocClientconsentdate = value;
                UpdateFieldValue("WocClientconsentdate", value);
            }
        }
        
        public DateTime? WocReceiveddate
        {
            get
            {
                return _wocReceiveddate;
            }
            set
            {
                _wocReceiveddate = value;
                UpdateFieldValue("WocReceiveddate", value);
            }
        }
        
        public DateTime? WocCompleteddate
        {
            get
            {
                return _wocCompleteddate;
            }
            set
            {
                _wocCompleteddate = value;
                UpdateFieldValue("WocCompleteddate", value);
            }
        }
        
        public int? WocCurrentstatusfk
        {
            get
            {
                return _wocCurrentstatusfk;
            }
            set
            {
                _wocCurrentstatusfk = value;
                UpdateFieldValue("WocCurrentstatusfk", value);
            }
        }
        
        public string WocCurrentstatusfkrefwocStatusname
        {
            get
            {
                return _wocCurrentstatusfkrefwocStatusname;
            }
            set
            {
                _wocCurrentstatusfkrefwocStatusname = value;
                UpdateFieldValue("WocCurrentstatusfkrefwocStatusname", value);
            }
        }
        
        public string WocPerformedby
        {
            get
            {
                return _wocPerformedby;
            }
            set
            {
                _wocPerformedby = value;
                UpdateFieldValue("WocPerformedby", value);
            }
        }
        
        public string WocComments
        {
            get
            {
                return _wocComments;
            }
            set
            {
                _wocComments = value;
                UpdateFieldValue("WocComments", value);
            }
        }
        
        public string WocSeqid
        {
            get
            {
                return _wocSeqid;
            }
            set
            {
                _wocSeqid = value;
                UpdateFieldValue("WocSeqid", value);
            }
        }
        
        public float? WocActiontrackingid
        {
            get
            {
                return _wocActiontrackingid;
            }
            set
            {
                _wocActiontrackingid = value;
                UpdateFieldValue("WocActiontrackingid", value);
            }
        }
        
        public int? WocRequesthhcmafk
        {
            get
            {
                return _wocRequesthhcmafk;
            }
            set
            {
                _wocRequesthhcmafk = value;
                UpdateFieldValue("WocRequesthhcmafk", value);
            }
        }
        
        public string WocRequesthhcmafkhhcmaname
        {
            get
            {
                return _wocRequesthhcmafkhhcmaname;
            }
            set
            {
                _wocRequesthhcmafkhhcmaname = value;
                UpdateFieldValue("WocRequesthhcmafkhhcmaname", value);
            }
        }
        
        public int? WocTargethhcmafk
        {
            get
            {
                return _wocTargethhcmafk;
            }
            set
            {
                _wocTargethhcmafk = value;
                UpdateFieldValue("WocTargethhcmafk", value);
            }
        }
        
        public string WocTargethhcmafkhhcmaname
        {
            get
            {
                return _wocTargethhcmafkhhcmaname;
            }
            set
            {
                _wocTargethhcmafkhhcmaname = value;
                UpdateFieldValue("WocTargethhcmafkhhcmaname", value);
            }
        }
    }
}
