using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MASHgame.Models
{
    public class Question

    {
        public Question () {
            this.Options = new HashSet<Option>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection <Option> Options {get; set;}
    }

}