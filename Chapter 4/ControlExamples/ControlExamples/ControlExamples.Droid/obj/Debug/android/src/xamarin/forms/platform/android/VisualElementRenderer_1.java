package xamarin.forms.platform.android;


public abstract class VisualElementRenderer_1
	extends com.xamarin.forms.platform.android.FormsViewGroup
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.VisualElementRenderer`1, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", VisualElementRenderer_1.class, __md_methods);
	}


	public VisualElementRenderer_1 (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == VisualElementRenderer_1.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.VisualElementRenderer`1, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public VisualElementRenderer_1 (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == VisualElementRenderer_1.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.VisualElementRenderer`1, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public VisualElementRenderer_1 (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == VisualElementRenderer_1.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.VisualElementRenderer`1, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
