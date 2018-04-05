﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RambollProject.Models
{
    public class GuideDTO
    {
        public GuideDTO(int id, string title, string description, string imgurl) {
            GuideDTOId = id;
            this.title = title;
            this.description = description;
            this.imgurl = imgurl;
            this.guideItems = null;
        }

        [Key]
        public int GuideDTOId { get; set; }
        public string title { get; set; }
        public string description{ get; set; }
        public string imgurl { get; set; }
        public ICollection<GuideItemDTO> guideItems { get; set; }


        public override string ToString()
        {
            return $"Guide: Id = {GuideDTOId}, Title = {title}, Description = {description}, ImageURI = {imgurl}";
        }
    }

    
}