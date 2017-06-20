using System.Threading.Tasks;
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

        public async override Task Initialize()
        {
            await base.Initialize();
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
