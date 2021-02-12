using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XW.EMR.SysManager.Model;

namespace XW.EMR.SysManager.Controllers
{
    [ApiController]
    [Route("Dept")]
    public class DeptController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            //List<string> deptList = 
            List<Department> deptList = new List<Department>();
            deptList.Add(new Department()
            {
                DeptId = 1,
                DeptCode = "0001",
                DeptName = "骨科"
            });
            deptList.Add(new Department()
            {
                DeptId = 2,
                DeptCode = "0002",
                DeptName = "全科"
            });

            return deptList;
        }
    }
}
