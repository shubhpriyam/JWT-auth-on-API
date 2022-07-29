using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthentication.DTOs;
using JWTAuthentication.Models;

namespace JWTAuthentication.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //SOurce - > target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
