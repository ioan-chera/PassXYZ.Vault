﻿
using System.Diagnostics;

namespace PassXYZ.Vault;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}


    protected override Window CreateWindow(IActivationState activationState)
    {
		return new PxWindow(new MainPage());
    }

    protected override void OnStart()
    {
        Debug.WriteLine("PassXYZ.Vault.App: OnStart");
    }

    protected override void OnSleep()
    {
        Debug.WriteLine("PassXYZ.Vault.App: OnSleep");
    }

    protected override void OnResume()
    {
        Debug.WriteLine("PassXYZ.Vault.App: OnResume");
    }
}
