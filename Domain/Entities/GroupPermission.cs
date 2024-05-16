﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GroupPermission : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual List<AssignGroup> AssignGroups { get; set; } = new List<AssignGroup>();
        public virtual List<AssignPermission> AssignPermissions { get; set; } = new List<AssignPermission>();
    }
}
