﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Plugin.Permissions;
// 底下的用法，可以參考 https://developer.xamarin.com/releases/android/mono_for_android_4/mono_for_android_4.0.0/
[assembly: UsesPermission(Name = Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Name = Android.Manifest.Permission.ReadExternalStorage)]
[assembly: UsesPermission(Name = Android.Manifest.Permission.WriteExternalStorage)]
[assembly: UsesPermission(Android.Manifest.Permission.Flashlight)]
[assembly: UsesPermission(Android.Manifest.Permission.Camera)]

namespace XFTask.Droid
{
    //[Activity(Label = "派工與回報", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    //public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    //{
    //    #region MainActivity Instance
    //    // Create a new instance field for this activity.
    //    static MainActivity instance = null;

    //    // Return the current activity instance.
    //    public static MainActivity CurrentActivity
    //    {
    //        get
    //        {
    //            return instance;
    //        }
    //    }

    //    #endregion
    //    protected override void OnCreate(Bundle bundle)
    //    {
    //        TabLayoutResource = Resource.Layout.tabs;
    //        ToolbarResource = Resource.Layout.toolbar;

    //        base.OnCreate(bundle);

    //        #region 設定該應用程式的主要 Activity
    //        instance = this;
    //        #endregion

    //        global::Xamarin.Forms.Forms.Init(this, bundle);

    //        #region 第三方套件/插件的初始化
    //        #endregion

    //        #region 進行 Azure Mobile Client 套件初始化
    //        Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

    //        #endregion

    //        LoadApplication(new App(new AndroidInitializer()));

    //        #region Firebase 的推播設定用程式碼
    //        #endregion
    //    }
    //    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
    //    {
    //        PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    //    }

    //    #region Firebase 的推播設定用程式碼
    //    #endregion
    //}

    //public class AndroidInitializer : IPlatformInitializer
    //{
    //    public void RegisterTypes(IUnityContainer container)
    //    {

    //    }
    //}

    [Activity(Label = "派工與回報", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        #region MainActivity Instance
        // Create a new instance field for this activity.
        static MainActivity instance = null;

        // Return the current activity instance.
        public static MainActivity CurrentActivity
        {
            get
            {
                return instance;
            }
        }

        #endregion

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.tabs;
            ToolbarResource = Resource.Layout.toolbar;

            base.OnCreate(bundle);

            #region 設定該應用程式的主要 Activity
            instance = this;
            #endregion

            global::Xamarin.Forms.Forms.Init(this, bundle);

            #region 第三方套件／插件的初始化
            #endregion

            #region 進行 Azure Mobile Client 套件初始化
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            #endregion

            LoadApplication(new App(new AndroidInitializer()));

            #region Firebase 的推播設定用程式碼
            #endregion
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        #region Firebase 的推播設定用程式碼
        #endregion

    }
    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}

