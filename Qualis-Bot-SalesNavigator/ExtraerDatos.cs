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
    ///The ExtraerDatos recording.
    /// </summary>
    [TestModule("64abd961-30b3-4128-87fa-642fbb73ced9", ModuleType.Recording, 1)]
    public partial class ExtraerDatos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Qualis_Bot_SalesNavigatorRepository repository.
        /// </summary>
        public static Qualis_Bot_SalesNavigatorRepository repo = Qualis_Bot_SalesNavigatorRepository.Instance;

        static ExtraerDatos instance = new ExtraerDatos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ExtraerDatos()
        {
            index = "1";
            Linkedin = "https://www.linkedin.com/sales/lead/ACwAACv7OpIBR6lrL8xDWDOmERx0VY-qID6Ygjw,NAME_SEARCH,-QMv?_ntb=uGcJ1ei%2BRJaDKr0E%2F0TMCw%3D%3D";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ExtraerDatos Instance
        {
            get { return instance; }
        }

#region Variables

        string _Linkedin;

        /// <summary>
        /// Gets or sets the value of variable Linkedin.
        /// </summary>
        [TestVariable("d632adf7-f5b0-48c1-ac01-95fbe977e55c")]
        public string Linkedin
        {
            get { return _Linkedin; }
            set { _Linkedin = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable index.
        /// </summary>
        [TestVariable("2fe17e89-d564-43eb-832f-8b412e95c8ef")]
        public string index
        {
            get { return repo.index; }
            set { repo.index = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.SalesQLBrowserExtensionButton' at Center.", repo.Chrome.SalesQLBrowserExtensionButtonInfo, new RecordItemIndex(0));
            repo.Chrome.SalesQLBrowserExtensionButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 13s.", new RecordItemIndex(1));
            Delay.Duration(13000, false);
            
            clickEnObtenerDatosONext();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(3));
            Delay.Duration(7000, false);
            
            ObtenerValoresEmail();
            Delay.Milliseconds(0);
            
            ObtenerValoresPhone();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}