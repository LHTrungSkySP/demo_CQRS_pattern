﻿using Application.Common.Mapping;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Dto
{
    public class UserDto : IMapFrom<Account>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Permissions { get; set; } = new List<string>();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Account, UserDto>()
                .ForMember(dest => dest.Permissions, opt => opt.MapFrom(src =>
                    src.AssignGroup
                        .SelectMany(ag => ag.GroupPermission.AssignPermissions)
                        .Select(ap => ap.Permission.Title)
                        .Distinct()
                        .ToList()));
        }
    }
}
