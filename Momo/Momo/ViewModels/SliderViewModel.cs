using Momo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms.Internals;

namespace Momo.ViewModels
{
    public interface ISlideViewModel { }
    public class SliderViewModel:BaseViewModel,ISlideViewModel
    {
        private ObservableCollection<SliderModel> _slider;
        public ObservableCollection<SliderModel> Sliders
        {
            get { return _slider; }
            set { _slider = value; OnPropertyChanged(nameof(Sliders)); }
        }
        [Preserve]
        public SliderViewModel()
        {
            LoadData();
        }
        private void LoadData()
        {
            var sliders = new List<SliderModel>
            {
                new SliderModel{ID=1,Uri="https://cafebiz.cafebizcdn.vn/thumb_w/600/2018/9/12/photo1536760206584-15367602065851855802683.jpg" },
                new SliderModel{ID=2,Uri="https://cafebiz.cafebizcdn.vn/thumb_w/600/2018/9/12/photo1536760206584-15367602065851855802683.jpg" }
            };
            Sliders = new ObservableCollection<SliderModel>(sliders);
        }
    }
}
