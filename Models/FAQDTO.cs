using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RambollProject.Models
{
    public class FAQDTO
    {
        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

        public FAQDTO(int id, string question, string answer)
        {
            this.id = id;
            this.question = question;
            this.answer= answer;
        }

        public override string ToString()
        {
            return $"FAQ: Id = {id}, Question = {question}, Answer= {answer}";
        }
    }
}