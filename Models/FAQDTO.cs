using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RambollProject.Models
{
    public class FAQDTO
    {
        [Key]
        public int FAQDTOid { get; set; }
        public string question { get; set; }
        public string answer { get; set; }


        public override string ToString()
        {
            return $"FAQ: Id = {FAQDTOid}, Question = {question}, Answer= {answer}";
        }
    }
}