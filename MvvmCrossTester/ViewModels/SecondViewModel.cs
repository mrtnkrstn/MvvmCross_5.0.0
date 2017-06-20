using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossTester
{
    public class SecondViewModel : MvxViewModel
    {
        public SecondViewModel()
        {
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
    }
}
