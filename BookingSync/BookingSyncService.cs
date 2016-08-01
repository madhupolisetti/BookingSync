using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BookingSync
{
    public partial class BookingSyncService : ServiceBase
    {
        private ApplicationController _applicationController = null;
        private System.Threading.Thread _controllerThread = null;
        public BookingSyncService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this._applicationController = new ApplicationController();
            this._controllerThread = new System.Threading.Thread(new System.Threading.ThreadStart(this._applicationController.Start));
            this._controllerThread.Name = "ApplicationController";
            this._controllerThread.Start();
        }

        protected override void OnStop()
        {
            SharedClass.Logger.Info("Stop Signal Received");
            System.Threading.Thread stopThread = new System.Threading.Thread(new System.Threading.ThreadStart(this._applicationController.Stop));
            stopThread.Name = "StopSignal";
            stopThread.Start();
            while (!SharedClass.IsServiceCleaned)
            {
                SharedClass.Logger.Info("Service not yet cleaned");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
