using System;
using System.Collections.Generic;

namespace LICENSESHOPER.DBModel
{
    public partial class LicenseActivator
    {
        public string UnlockCode { get; set; } = string.Empty;
        public string PartNumber { get; set; } = string.Empty;
    }
}
