﻿using OmniCore.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Client.Services
{
    public class CrossBlePeripheralLease : IRadioPeripheralLease
    {
        public IRadioPeripheral Peripheral { get => CrossBlePeripheral; }
        public CrossBleRadioPeripheral CrossBlePeripheral { get; set; }
        public CrossBlePeripheralLease(CrossBleRadioPeripheral peripheral)
        {
            CrossBlePeripheral = peripheral;
        }

        public void Dispose()
        {
            CrossBlePeripheral?.Release();
            CrossBlePeripheral = null;
        }
    }
}
