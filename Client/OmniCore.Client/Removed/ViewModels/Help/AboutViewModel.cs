﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OmniCore.Client.ViewModels.Help
{
    public class AboutViewModel : PageViewModel
    {
        public AboutViewModel(Page page) : base(page)
        {
        }

        public string Version
        {
            get
            {
                return XamarinApp.Instance.OmniCoreApplication.Version;
            }
        }

        [method: SuppressMessage("", "CS1998", Justification = "Not applicable")]
        protected async override Task<BaseViewModel> BindData()
        {
            return this;
        }

        protected override void OnDisposeManagedResources()
        {
        }
    }
}
