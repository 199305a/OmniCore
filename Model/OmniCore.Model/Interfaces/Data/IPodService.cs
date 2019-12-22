﻿using System.Collections.Generic;
using System.Threading.Tasks;
using OmniCore.Model.Interfaces.Data.Entities;
using OmniCore.Model.Interfaces.Platform;

namespace OmniCore.Model.Interfaces.Data
{
    public interface IPodService
    {
        IRadioService[] RadioProviders { get; }
        string Description { get; }
        IAsyncEnumerable<IPod> ActivePods();
        IAsyncEnumerable<IPod> ArchivedPods();
        Task<IPod> New(IUserEntity user, IMedicationEntity medication, IList<IRadioEntity> radios);
        Task<IPod> Register(IPodEntity pod, IUserEntity user, IList<IRadioEntity> radios);
    }
}