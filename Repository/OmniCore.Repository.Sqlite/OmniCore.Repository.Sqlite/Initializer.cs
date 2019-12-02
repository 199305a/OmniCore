﻿using OmniCore.Model.Interfaces.Repositories;
using OmniCore.Model.Interfaces.Services;
using OmniCore.Repository.Sqlite.Entities;
using OmniCore.Repository.Sqlite.Repositories;
using Unity;

namespace OmniCore.Repository.Sqlite
{
    public static class Initializer
    {
        public static IUnityContainer WithSqliteRepository(this IUnityContainer container)
        {
            
           
            container.RegisterType<IMedicationRepository, MedicationRepository>();
            container.RegisterType<IRadioEventRepository, RadioEventRepository>();
            container.RegisterType<IRadioRepository, RadioRepository>();
            container.RegisterType<ISignalStrengthRepository, SignalStrengthRepository>();
            container.RegisterType<IUserRepository, UserRepository>();

            container.RegisterSingleton<IRepositoryService, RepositoryService>();
            return container;
        }
    }
}
