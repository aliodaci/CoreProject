﻿using CoreProject.API.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using(var context=new Context())
            {
                var values = context.Employees.ToList();
                return Ok(values);
            }
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using (var context=new Context())
            {
                var values=context.Add(employee);
                context.SaveChanges();
                return Ok();
            }
            
        }

        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using (var context=new Context())
            {
                var employee=context.Employees.Find(id);
                if (employee == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(employee);
                }
            }
        }

        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using (var context=new Context())
            {
                var employee = context.Employees.Find(id);
                if (employee==null)
                {
                    return NotFound();
                }
                else
                {
                    context.Remove(employee);
                    context.SaveChanges() ;
                    return Ok();
                }
            }
        }

        [HttpPut]
        public IActionResult EmployeeUpdate(Employee employee)
        {
            using (var context=new Context())
            {
                var employeeValues = context.Find<Employee>(employee.Id);
                if (employeeValues==null)
                {
                    return NotFound();
                }
                else
                {
                    employeeValues.Name = employee.Name;
                    context.Update(employeeValues);
                    context.SaveChanges();
                    return Ok();
                }
            }
        }
    }
}
