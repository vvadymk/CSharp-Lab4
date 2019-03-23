﻿using System;
using System.Windows;
using KochmarLab4.Models;
using KochmarLab4.Tools.DataStorage;

namespace KochmarLab4.Tools.Managers
{
    internal static class StationManager
    {
        internal static Person CurrentUser { get; set; }

        private static IDataStorage _dataStorage;

        internal static IDataStorage DataStorage
        {
            get { return _dataStorage; }
        }

        internal static void Initialize(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            Environment.Exit(1);
        }

    }
}
