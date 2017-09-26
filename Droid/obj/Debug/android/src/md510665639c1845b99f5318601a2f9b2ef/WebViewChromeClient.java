package md510665639c1845b99f5318601a2f9b2ef;


public class WebViewChromeClient
	extends android.webkit.WebChromeClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_openFileChooser:(Landroid/webkit/ValueCallback;Ljava/lang/String;Ljava/lang/String;)V:__export__\n" +
			"n_onShowFileChooser:(Landroid/webkit/WebView;Landroid/webkit/ValueCallback;Landroid/webkit/WebChromeClient$FileChooserParams;)Z:GetOnShowFileChooser_Landroid_webkit_WebView_Landroid_webkit_ValueCallback_Landroid_webkit_WebChromeClient_FileChooserParams_Handler\n" +
			"";
		mono.android.Runtime.register ("BeachHead.Droid.Render.WebViewChromeClient, BeachHead.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WebViewChromeClient.class, __md_methods);
	}


	public WebViewChromeClient () throws java.lang.Throwable
	{
		super ();
		if (getClass () == WebViewChromeClient.class)
			mono.android.TypeManager.Activate ("BeachHead.Droid.Render.WebViewChromeClient, BeachHead.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void openFileChooser (android.webkit.ValueCallback p0, java.lang.String p1, java.lang.String p2)
	{
		n_openFileChooser (p0, p1, p2);
	}

	private native void n_openFileChooser (android.webkit.ValueCallback p0, java.lang.String p1, java.lang.String p2);


	public boolean onShowFileChooser (android.webkit.WebView p0, android.webkit.ValueCallback p1, android.webkit.WebChromeClient.FileChooserParams p2)
	{
		return n_onShowFileChooser (p0, p1, p2);
	}

	private native boolean n_onShowFileChooser (android.webkit.WebView p0, android.webkit.ValueCallback p1, android.webkit.WebChromeClient.FileChooserParams p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
