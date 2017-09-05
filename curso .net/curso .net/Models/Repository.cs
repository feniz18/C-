using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace curso.net.Models
{
    public class Repository
    {
        public Demo GetDemo()
        {

            return new Demo
            {

                Message = "hello world",
                MessageHtml = "<h1>Hello world</H1>"

            };

        }
    }
}