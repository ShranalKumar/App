package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("MyApp.Droid.MainApplication, MyApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", md5f60d67082f91e2b9b42576ed8c45c8c1.MainApplication.class, md5f60d67082f91e2b9b42576ed8c45c8c1.MainApplication.__md_methods);
		
	}
}
