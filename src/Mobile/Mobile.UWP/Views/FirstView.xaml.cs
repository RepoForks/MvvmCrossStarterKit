﻿using MvvmCross.Uwp.Views;
using Mobile.Core.ViewModels;

namespace Mobile.UWP.Views
{
	[MvxRegion("MainContent")]
	public sealed partial class FirstView
	{
		public new FirstViewModel ViewModel
		{
			get => (FirstViewModel) base.ViewModel;
		    set => base.ViewModel = value;
		}

		public FirstView()
		{
			InitializeComponent();
		}
	}
}
