package xamarin.forms.platform.android;


public class SearchBarRenderer
	extends xamarin.forms.platform.android.ViewRenderer_2
	implements
		mono.android.IGCUserPeer,
		android.widget.SearchView.OnQueryTextListener,
		android.view.View.OnFocusChangeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onQueryTextChange:(Ljava/lang/String;)Z:GetOnQueryTextChange_Ljava_lang_String_Handler:Android.Widget.SearchView/IOnQueryTextListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onQueryTextSubmit:(Ljava/lang/String;)Z:GetOnQueryTextSubmit_Ljava_lang_String_Handler:Android.Widget.SearchView/IOnQueryTextListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onFocusChange:(Landroid/view/View;Z)V:GetOnFocusChange_Landroid_view_View_ZHandler:Android.Views.View/IOnFocusChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.SearchBarRenderer, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", SearchBarRenderer.class, __md_methods);
	}


	public SearchBarRenderer (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == SearchBarRenderer.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.SearchBarRenderer, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public SearchBarRenderer (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == SearchBarRenderer.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.SearchBarRenderer, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public SearchBarRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == SearchBarRenderer.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.SearchBarRenderer, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean onQueryTextChange (java.lang.String p0)
	{
		return n_onQueryTextChange (p0);
	}

	private native boolean n_onQueryTextChange (java.lang.String p0);


	public boolean onQueryTextSubmit (java.lang.String p0)
	{
		return n_onQueryTextSubmit (p0);
	}

	private native boolean n_onQueryTextSubmit (java.lang.String p0);


	public void onFocusChange (android.view.View p0, boolean p1)
	{
		n_onFocusChange (p0, p1);
	}

	private native void n_onFocusChange (android.view.View p0, boolean p1);

	java.util.ArrayList refList;
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
