using System;
using BeachHead;
using BeachHead.iOS.Render;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(WebViewer), typeof(WebViewRender))]
namespace BeachHead.iOS.Render
{
	using System.Threading.Tasks;
	using UIKit;
	using Xamarin.Forms.Platform.iOS;

	public class WebViewRender : WebViewRenderer
	{

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (NativeView != null && e.NewElement != null)
				InitializeCommands((WebViewer)e.NewElement);

			var webView = e.NewElement as WebViewer;
			if (webView != null)
				webView.EvaluateJavascript = (js) =>
				{
					return Task.FromResult(this.EvaluateJavascript(js));
				};
		}

		private void InitializeCommands(WebViewer element)
		{
			element.Refresh = () =>
			{
				((UIWebView)NativeView).Reload();
			};

			element.GoBack = () =>
			{
				var control = ((UIWebView)NativeView);
				if (control.CanGoBack)
				{
					control.GoBack();
				}
			};

			element.CanGoBackFunction = () =>
			{
				return ((UIWebView)NativeView).CanGoBack;
			};

			var ctl = ((UIWebView)NativeView);

			ctl.ScalesPageToFit = true;

		}

	}
}
