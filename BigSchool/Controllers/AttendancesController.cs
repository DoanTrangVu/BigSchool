﻿using BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BigSchool.DTOs;
using BigSchool.DTOs;
//using Microsoft.Azure.Documents;

namespace BigSchool.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attendance already exists!");
            var attendane = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId //User.Identity.GetUserId()
            };
            _dbContext.Attendances.Add(attendane);
            _dbContext.SaveChanges();
            return Ok();
        }
    }

}


