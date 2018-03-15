using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using QRXamarin.Annotations;
using Xamarin.Forms;
using ZXing.Common;


namespace QRXamarin
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }




        public EncodingOptions BarcodeOption => new EncodingOptions() { Height = 100, Width = 100, PureBarcode = true };
    }
}
