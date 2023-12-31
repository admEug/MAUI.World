﻿using System.Windows.Input;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.Input;

namespace CommunityToolkit.Maui.Sample.ViewModels.Behaviors;

public partial class AnimationBehaviorViewModel : BaseViewModel
{
	[RelayCommand]
	Task OnAnimation(CancellationToken token) => Snackbar.Make($"{nameof(AnimationCommand)} is triggered.").Show(token);
}