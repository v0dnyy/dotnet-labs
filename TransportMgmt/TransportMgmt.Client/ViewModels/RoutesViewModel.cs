﻿using ReactiveUI;
using System.ComponentModel.DataAnnotations;

namespace TransportMgmt.Client.ViewModels;

public class RoutesViewModel : ViewModelBase
{
    private int _id;
    public int Id
    {
        get => _id;
        set => this.RaiseAndSetIfChanged(ref _id, value);
    }

    private string _routeNumber = string.Empty;
    [Required]
    public string RouteNumber
    {
        get => _routeNumber;
        set => this.RaiseAndSetIfChanged(ref _routeNumber, value);
    }

}
