﻿using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossTester
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navService;

        public FirstViewModel(IMvxNavigationService navService)
        {
            _navService = navService;
        }

        public override void Start()
        {
            base.Start();
        }

        public override void Appearing()
        {
            base.Appearing();
        }

        private MvxCommand _navigateCommand;
        public MvxCommand NavigateCommand
        {
            get {
                return _navigateCommand ?? (_navigateCommand = new MvxCommand(async () =>
                {
                    await _navService.Navigate<SecondViewModel>();
                }));
            }
        }
    }
}
