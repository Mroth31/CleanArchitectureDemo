﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;

namespace CleanArch.Application.Automapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}