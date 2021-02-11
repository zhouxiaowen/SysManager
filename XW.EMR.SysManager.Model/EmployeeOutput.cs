using System;
using System.Collections.Generic;
using System.Text;

namespace XW.EMR.SysManager.Model
{
    public class EmployeeOutput
    {
        public string EmplCode { set; get; }

        public string EmplName { set; get; }
        public string Age { set; get; }
        public string CardNo { set; get; }
        public DateTime? Birthday { set; get; }

        public string Address { set; get; }

    }
}
