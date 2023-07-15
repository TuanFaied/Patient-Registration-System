using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration_System.ViewModel
{
   public class ShareViewModel: INotifyPropertyChanged
    {
        private string _valueToTransfer;
        public string ValueToTransfer
        {
            get { return _valueToTransfer; }
            set
            {
                _valueToTransfer = value;
                OnPropertyChanged(nameof(ValueToTransfer));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
