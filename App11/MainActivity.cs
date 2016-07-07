using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System.Threading;

namespace App11
{
    [Activity(Label = "App11", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            Button button1 = FindViewById<Button>(Resource.Id.MyCancelButton);
            Button button2 = FindViewById<Button>(Resource.Id.MyCancelButton2);

            var cts1 = new CancellationTokenSource();
            var cts2 = new CancellationTokenSource();

            button1.Click += (sender, args) =>
            {
                cts1.Cancel();
            };
            button2.Click += (sender, args) =>
            {
                cts2.Cancel();
            };
            button.Click += async delegate {
                #region Tasks 1

                //var t1 = Task.Run(()=>
                //{
                //    Console.WriteLine("Task 1 run");
                //});
                //var t2 = Task.Run(() =>
                //{
                //    Console.WriteLine("Task 2 run");
                //});
                //var t3 = Task.Run(() =>
                //{
                //    Console.WriteLine("Task 3 run");
                //});
                #endregion

                #region Tasks 2

                //var locker1 = new object();
                //var locker2 = new object();
                //Task.Run(() =>
                //{
                //    lock (locker1)
                //    {
                //        Console.WriteLine("Thread 1 locked locker1");
                //        Thread.Sleep(1000);
                //        lock (locker2)
                //        {
                //            Console.WriteLine("Thread 1 got both locks");
                //        }

                //    }
                //    Console.WriteLine("Thread 1 finished");
                //});


                //Task.Run(() =>
                //{
                //    // thread 2
                //    lock (locker2)
                //    {
                //        Console.WriteLine("Thread 2 locked locker2");
                //        Thread.Sleep(1000);
                //        lock (locker1)
                //        {
                //            Console.WriteLine("Thread 2 got both locks");
                //        }
                //    }
                //    Console.WriteLine("Thread 2 finished");
                //});
                #endregion

                #region Tasks 3
                //var t1 = Task.Run(() =>
                //{
                //    Console.WriteLine("Task 1 run");
                //});
                //var t2 = Task.Run(() =>
                //{
                //    throw new Exception();
                //});

                //t1.ContinueWith((t) =>
                //{
                //    Console.WriteLine("Task 1 finished");
                //});

                //t2.ContinueWith((t)=>
                //{
                //    Console.WriteLine("Task 2 finished");
                //});

                //t1.ContinueWith(t =>
                //{
                //    Console.WriteLine("Task 1 Completed successfully");

                //}, TaskContinuationOptions.OnlyOnRanToCompletion);
                //t2.ContinueWith(t =>
                //{
                //    Console.WriteLine("Task 2 Completed successfully");

                //}, TaskContinuationOptions.OnlyOnRanToCompletion);


                //t1.ContinueWith(t =>
                //{
                //    Console.WriteLine("Task 1 failed");

                //}, TaskContinuationOptions.OnlyOnFaulted);
                //t2.ContinueWith(t =>
                //{
                //    Console.WriteLine("Task 2 failed");

                //}, TaskContinuationOptions.OnlyOnFaulted);
                #endregion

                #region Tasks 4
                //var cts = CancellationTokenSource.CreateLinkedTokenSource(cts1.Token, cts2.Token);

                //Task.Run(()=>
                //{
                //    var i = 0;
                //    for (i = 0; i < Int32.MaxValue; i++)
                //    {
                //        if (cts.Token.IsCancellationRequested)
                //            cts.Token.ThrowIfCancellationRequested();

                //        Console.WriteLine(i);
                //    }


                //}, cts.Token);

                #endregion

                #region Tasks 5

                //Task.Run(()=> { }).ContinueWith(t => {
                //    try
                //    {
                //            button.Text = "From background thread";
                //    } catch (Exception e)
                //    {
                //        Console.WriteLine(e.ToString());
                //    }
                //}, TaskScheduler.FromCurrentSynchronizationContext());

                #endregion

                #region Tasks 6
                await Task.Run(() =>
                {
                    Console.WriteLine("Background task working");
                }).ConfigureAwait(false);
                button.Text = "from bckg";

                #endregion
            };
        }
    }
}

