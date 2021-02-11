using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XW.EMR.SysManager.Model;

namespace XW.EMR.SysManager.Services.Controllers
{
    [ApiController]
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("get-employeelist")]
        public IEnumerable<EmployeeOutput> Get()
        {
            var employeeList = new List<EmployeeOutput>();
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000296289",
                EmplName = "李永纯",
                Age = "",
                Birthday = DateTime.Now,
                Address = "江苏江宁县",
                CardNo = "210311192709191523"
            });
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000296294",
                EmplName = "夏德义",
                Age = "",
                Birthday = DateTime.Now,
                Address = "陕西汉阴县",
                CardNo = "612422670614421"
            });
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000296508",
                EmplName = "孙庆泉",
                Age = "",
                Birthday = DateTime.Now,
                Address = "辽宁昌图县",
                CardNo = "210311199411011528"
            });
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000296528",
                EmplName = "王石",
                Age = "",
                Birthday = DateTime.Now,
                Address = "辽宁朝阳县",
                CardNo = "210304198805101632"
            });
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000296240",
                EmplName = "丁德霞",
                Age = "",
                Birthday = DateTime.Now,
                Address = "江苏江宁县",
                CardNo = "21030219631027242x"
            });
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000296403",
                EmplName = "张服娟",
                Age = "",
                Birthday = DateTime.Now,
                Address = "黑龙江东宁县",
                CardNo = "210882198706050311"

            });
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000681598",
                EmplName = "余江明",
                Age = "",
                Birthday = DateTime.Now,
                Address = "黑龙江五大连池市",
                CardNo = "220821198104272522"
            });
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000772218",
                EmplName = "禹金龙",
                Age = "",
                Birthday = DateTime.Now,
                Address = "江苏响水县",
                CardNo = "210381197604285111"
            });
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000829198",
                EmplName = "王明",
                Age = "",
                Birthday = DateTime.Now,
                Address = "河南林县",
                CardNo = "372924197603264812"
            });
            employeeList.Add(new EmployeeOutput()
            {
                EmplCode = "3000822298",
                EmplName = "孙一军",
                Age = "",
                Birthday = DateTime.Now,
                Address = "辽宁岫岩满族自治县",
                CardNo = "210381197912093816"
            });

            return employeeList;
        }
    }
}
