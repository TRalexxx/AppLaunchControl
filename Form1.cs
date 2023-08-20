using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AppLaunchControl
{
    public partial class Form1 : Form
    {
        bool isWork = false;
        List<AppClass> apps = new List<AppClass>();

        private Process currProc = new Process();

        private DateTime exitTime = DateTime.MinValue;
        private TaskCompletionSource<bool> eventHandled;

        public Form1()
        {
            InitializeComponent();
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "exe files (*.exe)|*.exe";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;

                appPathTB.Text = path;
            }
        }

        private void deleteFromListBtn_Click(object sender, EventArgs e)
        {
            programLB.Items.Remove(programLB.SelectedItem);
        }

        private void CatchExitTime(object sender, EventArgs e)
        {
            bool isDone = false;
            Monitor.Enter(currProc);
            try
            {
                if (currProc.EnableRaisingEvents && !isDone)
                {
                    exitTime = currProc.ExitTime;

                    var workTime = (exitTime - currProc.StartTime).TotalSeconds;

                    apps.FirstOrDefault(x => x.AppName.Equals(currProc.ProcessName.ToString())).LimitTime =
                        apps.FirstOrDefault(x => x.AppName.Equals(currProc.ProcessName.ToString())).LimitTime - (int)workTime;

                }

            }
            finally 
            { 
                isDone = true;
                Monitor.Exit(currProc); 
            }
                        
        }

        private async void AppMonitor()
        {
            eventHandled = new TaskCompletionSource<bool>();

            while (isWork)
            {
                if (programLB.Items.Count > 0)
                {
                    foreach (var item in programLB.Items)
                    {
                        var list = Process.GetProcessesByName(item.ToString());
                        if (list.Count() > 0 && list != null)
                        {
                            currProc = list.FirstOrDefault();
                            if (currProc != null && !currProc.HasExited)
                            {
                                currProc.EnableRaisingEvents = true;
                                currProc.Exited += new EventHandler(CatchExitTime);
                                try
                                {
                                    var seconds = (DateTime.Now - list.First().StartTime).TotalSeconds;


                                    if (seconds >= apps.FirstOrDefault(x => x.AppName.Equals(currProc.ProcessName)).LimitTime)
                                    {
                                        try
                                        {
                                            currProc.Kill();
                                            apps.FirstOrDefault(x => x.AppName.Equals(currProc.ProcessName)).LimitTime = 0;
                                        }
                                        catch (Exception ex) { }
                                    }

                                }
                                catch (Exception ex) { }

                                await Task.WhenAny(eventHandled.Task, Task.Delay(1000));
                            }

                        }
                    }

                }
            }
        }

        Thread th1;

        private void startMonitorBtn_Click(object sender, EventArgs e)
        {
            if (!isWork)
            {
                isWork = true;
                th1 = new Thread(AppMonitor);
                th1.Start();

                monitorWorkingLabel.Visible = true;
            }
        }

        private void stopMonitorBtn_Click(object sender, EventArgs e)
        {
            if (isWork)
            {
                isWork = false;
                th1.Interrupt();

                monitorWorkingLabel.Visible = false;
            }
        }

        private void addAppBtn_Click(object sender, EventArgs e)
        {
            string appName = appPathTB.Text.Split('\\').Last();
            if (!appPathTB.Text.Equals("") && appPathTB.Text != null)
            {
                appName = appName.Substring(0, appName.Length - 4);

                if (!programLB.Items.Contains(appName) && !appPathTB.Text.Equals("H:\\Git\\AppLaunchControl\\bin\\Debug\\net6.0-windows\\AppLaunchControl.exe"))
                {
                    programLB.Items.Add(appName);

                    apps.Add(new AppClass
                    {
                        AppName = appName,
                        LimitTime = (int)timeNUD.Value * 60,
                    });
                }
            }
        }
    }
}