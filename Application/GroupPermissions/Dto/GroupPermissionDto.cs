﻿using Application.Common.Mapping;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.GroupPermissions.Dto
{
    public class GroupPermissionDto : IMapFrom<GroupPermission>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual List<AssignGroup>? AssignGroups { get; set; } = new List<AssignGroup>();
        public virtual List<AssignPermission>? AssignPermissions { get; set; } = new List<AssignPermission>();
    }
}