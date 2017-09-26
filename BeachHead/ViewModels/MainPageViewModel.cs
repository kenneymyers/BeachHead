using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeachHead.ViewModels
{
	public class MainPageViewModel : BindableObject
	{

		public Func<string, Task<string>> EvaluateJavascript { get; set; }
		public Action GoBack { get; set; }
		public Action Refresh { get; set; }
		public string DataValue { get; set; }

		public ICommand GoBackCommand
		{
			get
			{
				return new Command(() => { GoBack(); });
			}
		}

		public ICommand RefreshCommand
		{
			get
			{
				return new Command(() => { Refresh(); });
			}
		}

		public ICommand EvalJS
		{
			get
			{
				return new Command(async () =>
				{
					DataValue = await EvaluateJavascript("localStorage.getItem('accessToken');");
					System.Diagnostics.Debug.WriteLine("DataValue - " + DataValue);
				});
			}
		}

	}
}
