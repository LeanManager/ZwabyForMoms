﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Xamarin.FormsBook.Toolkit
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		/* The first argument to SetProperty is a reference to the backing field, and 
		   the second argument is the value being set to the property. SetProperty automates 
		   the checking and setting of the backing field. 
		   Notice that it explicitly includes the propertyName argument when calling OnPropertyChanged.
		   (Otherwise the propertyName argument would become the string “SetProperty”!) 
		   The method returns true if the property was changed. 
		   You can use this return value to perform additional processing with the new value. */

		protected bool SetProperty<T>(ref T storage, T value,
									  [CallerMemberName] string propertyName = null)
		{
			if (Object.Equals(storage, value))
				return false;

			storage = value;
			OnPropertyChanged(propertyName);
			return true;
		}

		// ------------------------------------------------------------------------------------------- //

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// ------------------------------------------------------------------------------------------- //

	}
}