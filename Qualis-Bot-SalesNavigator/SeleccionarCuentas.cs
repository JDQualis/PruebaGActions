﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Qualis_Bot_SalesNavigator
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SeleccionarCuentas recording.
    /// </summary>
    [TestModule("4cb1f3dd-0957-40dc-8103-0867648d0bab", ModuleType.Recording, 1)]
    public partial class SeleccionarCuentas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Qualis_Bot_SalesNavigatorRepository repository.
        /// </summary>
        public static Qualis_Bot_SalesNavigatorRepository repo = Qualis_Bot_SalesNavigatorRepository.Instance;

        static SeleccionarCuentas instance = new SeleccionarCuentas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SeleccionarCuentas()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SeleccionarCuentas Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(0));
            Delay.Duration(7000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InicioSalesNavigator.Cuentas' at Center.", repo.InicioSalesNavigator.CuentasInfo, new RecordItemIndex(1));
            repo.InicioSalesNavigator.Cuentas.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InicioSalesNavigator.Cuentas' at Center.", repo.InicioSalesNavigator.CuentasInfo, new RecordItemIndex(3));
            repo.InicioSalesNavigator.Cuentas.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}