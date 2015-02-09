package xamarin.forms.platform.android;


public class ListViewAdapter
	extends xamarin.forms.platform.android.CellAdapter
	implements
		mono.android.IGCUserPeer,
		android.widget.AdapterView.OnItemClickListener,
		android.widget.AdapterView.OnItemLongClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_hasStableIds:()Z:GetHasStableIdsHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_isEnabled:(I)Z:GetIsEnabled_IHandler\n" +
			"n_onItemClick:(Landroid/widget/AdapterView;Landroid/view/View;IJ)V:GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler:Android.Widget.AdapterView/IOnItemClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onItemLongClick:(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z:GetOnItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler:Android.Widget.AdapterView/IOnItemLongClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.ListViewAdapter, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", ListViewAdapter.class, __md_methods);
	}


	public ListViewAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ListViewAdapter.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ListViewAdapter, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public ListViewAdapter (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == ListViewAdapter.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ListViewAdapter, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public boolean hasStableIds ()
	{
		return n_hasStableIds ();
	}

	private native boolean n_hasStableIds ();


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public boolean isEnabled (int p0)
	{
		return n_isEnabled (p0);
	}

	private native boolean n_isEnabled (int p0);


	public void onItemClick (android.widget.AdapterView p0, android.view.View p1, int p2, long p3)
	{
		n_onItemClick (p0, p1, p2, p3);
	}

	private native void n_onItemClick (android.widget.AdapterView p0, android.view.View p1, int p2, long p3);


	public boolean onItemLongClick (android.widget.AdapterView p0, android.view.View p1, int p2, long p3)
	{
		return n_onItemLongClick (p0, p1, p2, p3);
	}

	private native boolean n_onItemLongClick (android.widget.AdapterView p0, android.view.View p1, int p2, long p3);

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
