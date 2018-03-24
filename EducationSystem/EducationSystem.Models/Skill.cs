﻿using EducationSystem.Models.Enums;
using System.Collections.Generic;

namespace EducationSystem.Models
{
    public class Skill
    {
        public Skill()
        {
            Rank = new HashSet<Feedback>();
        }
        public SkillType Type { get; set; }

        public ICollection<Feedback> Rank { get; set; }
    }
}
