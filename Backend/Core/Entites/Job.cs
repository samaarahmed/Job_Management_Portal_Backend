﻿using Backend.Core.Enums;

namespace Backend.Core.Entites
{
    public class Job:BaseEntity
    {
        public string Title { get; set; }
        public JobLevel Level { get; set; }

        // Relations

        public long CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<Candidate> Candidates { get; set;}
    }
}
