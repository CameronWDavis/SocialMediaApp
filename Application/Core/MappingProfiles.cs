using System;
using AutoMapper;
using Domain;
using Persistence;

namespace Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Activity, Activity>(); 
    }
}