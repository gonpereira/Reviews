using Microsoft.AspNetCore.Mvc;
using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            People people = new People();

            people.pplList.Add(new Person()
            {
                Id = 0,
                Name = "Susan Smith",
                Job = "Web Developer",
                Image = "https://res.cloudinary.com/diqqf3eq2/image/upload/v1586883334/person-1_rfzshl.jpg",
                Text = "I'm baby meggings twee health goth +1. Bicycle rights tumeric chartreuse before they sold out chambray pop-up. Shaman humblebrag pickled coloring book salvia hoodie, cold-pressed four dollar toast everyday carry"
            });

            people.pplList.Add(new Person()
            {
                Id = 1,
                Name = "Ana Johnson",
                Job = "Web Designer",
                Image = "https://res.cloudinary.com/diqqf3eq2/image/upload/v1586883409/person-2_np9x5l.jpg",
                Text = "Helvetica artisan kinfolk thundercats lumbersexual blue bottle. Disrupt glossier gastropub deep v vice franzen hell of brooklyn twee enamel pin fashion axe.photo booth jean shorts artisan narwhal."
            });       


            return View(people);
            
        }

    }
}
