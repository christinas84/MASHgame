using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MASHgame.Models
{
    public class Option
    {

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Description { get; set; }

        public virtual Question Question { get; set; }
    }

}