using System;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossTester
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
