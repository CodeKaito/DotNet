using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Myapp.Models.ValueTypes;

namespace Myapp.Models.ViewModels
{
    public class CourseDetailViewModel: CourseViewModel
    {
        public string Description { get; set; }
        public List<LessonViewModel> Lessons { get; set; }
    }
}