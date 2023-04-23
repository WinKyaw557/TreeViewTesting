using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Collections.Generic;
using TreeViewNet6.Models;

namespace TreeViewNet6.Controllers
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

        public IActionResult byaction(int Id)
        {
            List<SectionModel> list = new();
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

        [HttpGet("grade")]
        public IActionResult GradeAction()
        {
            List<TreeViewModel> list = new();
            TreeViewModel result1 = new TreeViewModel { Id = 1, Name = "Grade A" };
            list.Add(result1);
            TreeViewModel result2 = new TreeViewModel { Id = 2, Name = "Grade B" };
            list.Add(result2);
            TreeViewModel result3 = new TreeViewModel { Id = 3, Name = "Grade C" };
            list.Add(result3);
            return Ok(list);
        }
    }
}
