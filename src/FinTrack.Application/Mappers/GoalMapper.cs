﻿using AutoMapper;
using FinTrack.Application.Handlers.v1.Goal.CreateGoal;
using FinTrack.Application.Models.Request;
using FinTrack.Domain.Entities;

namespace FinTrack.Application.Mappers;

public class GoalMapper : Profile
{
    public GoalMapper()
    {
        CreateMap<CreateGoalCommand, PostCreateFinancialGoalRequest>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Payload!.Name))
             .ForMember(dest => dest.GoalAmount, opt => opt.MapFrom(src => src.Payload!.GoalAmount))
             .ForMember(dest => dest.IdealMonthlySaving, opt => opt.MapFrom(src => src.Payload!.IdealMonthlySaving))
             .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Payload!.Status))
             .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.Payload!.Deadline));

        CreateMap<PostCreateFinancialGoalRequest, CreateGoalResult>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
             .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt));

        CreateMap<PostCreateFinancialGoalRequest, Goal>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.GoalAmount, opt => opt.MapFrom(src => src.GoalAmount))
            .ForMember(dest => dest.IdealMonthlySaving, opt => opt.MapFrom(src => src.IdealMonthlySaving))
            .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
            .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.Deadline))
            .ForMember(dest => dest.Transactions, opt => opt.MapFrom(src => src.Transactions))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));
    }
}
