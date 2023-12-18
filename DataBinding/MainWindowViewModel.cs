using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		private int boundNumber;

		public event PropertyChangedEventHandler PropertyChanged;

		public int BoundNumber
		{
			get
			{
				return boundNumber;
			}
			set
			{
				if (boundNumber != value)
				{
					boundNumber = value;
					OnPropertyChanged("BoundNumber");
				}
			}
		}

		public void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
