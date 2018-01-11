using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RambollProject.Models
{
    public class GuideDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description{ get; set; }
        public Uri imgurl { get; set; }

        public GuideDTO(int id, string title, string description, string imgurl)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.imgurl = new Uri(imgurl);
        }

        public override string ToString()
        {
            return $"Guide: Id = {id}, Title = {title}, Description = {description}, ImageURI = {imgurl}";
        }
    }

    
}