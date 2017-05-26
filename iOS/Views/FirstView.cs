using System;
using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace MvvmCrossTester.iOS
{
    public class FirstView : MvxViewController<FirstViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;

            var bindingSet = this.CreateBindingSet<FirstView, FirstViewModel>();

            var button = UIButton.FromType(UIButtonType.System);
            button.TranslatesAutoresizingMaskIntoConstraints = false;
            button.SetTitle("Tap Me", UIControlState.Normal);

            bindingSet.Bind(button).To(vm => vm.NavigateCommand);

            Add(button);

            bindingSet.Apply();

            View.AddConstraints(new FluentLayout [] {
                button.WithSameCenterX(View),
                button.WithSameCenterY(View)
            });
        }
    }
}
