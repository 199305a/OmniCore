﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OmniCore.Model.Interfaces.Services;

namespace OmniCore.Services
{
    public class CoreServicesProvider : ICoreServicesProvider
    {
        public ICoreServices LocalServices { get; }
        public CoreServicesProvider(ICoreServices localServices)
        {
            LocalServices = localServices;
        }

        public async Task<ICoreServices> GetRemoteServices(ICoreServicesDescriptor serviceDescriptor, ICoreCredentials credentials)
        {
            return null;
        }

        public async Task<IAsyncEnumerable<ICoreServicesDescriptor>> ListRemoteServices()
        {
            return null;
        }
    }
}
