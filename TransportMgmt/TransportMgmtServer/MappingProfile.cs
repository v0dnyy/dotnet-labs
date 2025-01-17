﻿using AutoMapper;
using TransportMgmt.Domain;
using TransportMgmtServer.Dto;

namespace TransportMgmtServer;
/// <summary>
/// A class that allows you to mapping some types to other types
/// </summary>
public class MappingProfile : Profile
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public MappingProfile()
    {
        CreateMap<Model, ModelGetDto>();
        CreateMap<Model, ModelPostDto>();

        CreateMap<ModelPostDto, Model>();

        CreateMap<Driver, DriverGetDto>();
        CreateMap<Driver, DriverPostDto>();

        CreateMap<DriverPostDto, Driver>();

        CreateMap<Transport, TransportGetDto>();
        CreateMap<Transport, TransportPostDto>();

        CreateMap<TransportPostDto, Transport>();

        CreateMap<Trip, TripGetDto>();
        CreateMap<Trip, TripPostDto>();

        CreateMap<TripPostDto, Trip>();

        CreateMap<Routes, RoutesGetDto>();

        CreateMap<TransportType, TransportTypesGetDto>();
    }
}
