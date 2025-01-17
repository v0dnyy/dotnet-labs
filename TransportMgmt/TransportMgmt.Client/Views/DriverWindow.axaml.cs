using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System;
using TransportMgmt.Client.ViewModels;

namespace TransportMgmt.Client.Views;

public partial class DriverWindow : ReactiveWindow<DriverViewModel>
{
    public DriverWindow()
    {
        InitializeComponent();

        this.WhenActivated(d => d(ViewModel!.DriverOnSubmitCommand.Subscribe(Close)));
    }

    public void CancelButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}
