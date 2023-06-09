﻿
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreeViewTesting.Models;

namespace TreeViewTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreeViewController : ControllerBase
    {
        [HttpGet("lecture")]

        public IActionResult getAction(int id)
        {
            List<LecturesModel> list = new();
            LecturesModel result1 = new() { Id = 1, Name = "Math" };
            list.Add(result1);
            LecturesModel result2 = new() { Id = 2, Name = "Law" };
            list.Add(result2);
            LecturesModel result3 = new() { Id = 3, Name = "Eng" };
            list.Add(result3);
            return Ok(list);
        }
        //Section api
        [HttpGet("section")]

        public IActionResult byaction(int id)
        {
            List<SectionModel> list= new();
            SectionModel result1 = new() { Id = 1, Name = "A" };
            list.Add(result1);
            SectionModel result2 = new() { Id = 2, Name = "B" };
            list.Add(result2);
            SectionModel result3 = new() { Id = 3, Name = "C" };
            list.Add(result3);
            return Ok(list);
        }

        //student api
        [HttpGet("student")]
        public IActionResult StudentAction()
        {
            List<StudentsModel> list = new();
            StudentsModel result1 = new StudentsModel { Id = 1, Name = "Aye Aye" };
            list.Add(result1);
            StudentsModel result2 = new StudentsModel { Id = 2, Name = "Aung Aung" };
            list.Add(result2);
            StudentsModel result3 = new StudentsModel { Id = 3, Name = "Win Win" };
            list.Add(result3);
            return Ok(list);
        }
    }
}
