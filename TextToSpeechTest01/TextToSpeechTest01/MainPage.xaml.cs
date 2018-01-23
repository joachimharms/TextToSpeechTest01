using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TextToSpeechTest01
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}


		private void Button_OnClicked(object sender, EventArgs e)
		{
			var text = MainEntry.Text;

			CrossTextToSpeech.Current.Speak(text);
		}

	}
}
