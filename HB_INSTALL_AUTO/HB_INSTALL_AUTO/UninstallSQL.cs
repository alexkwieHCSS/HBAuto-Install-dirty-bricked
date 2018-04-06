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

namespace HB_INSTALL_AUTO
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UninstallSQL recording.
    /// </summary>
    [TestModule("19c0f50a-d08e-4dfb-82fe-befaf85a22ae", ModuleType.Recording, 1)]
    public partial class UninstallSQL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static UninstallSQL instance = new UninstallSQL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UninstallSQL()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UninstallSQL Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'ProgramsAndFeatures.SearchEditBox'", repo.ProgramsAndFeatures.SearchEditBoxInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.ProgramsAndFeatures.SearchEditBoxInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProgramsAndFeatures.SearchEditBox' at 2;10.", repo.ProgramsAndFeatures.SearchEditBoxInfo, new RecordItemIndex(1));
            repo.ProgramsAndFeatures.SearchEditBox.Click("2;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'microsoft{Space}SQL{Space}2012' with focus on 'ProgramsAndFeatures.SearchEditBox'.", repo.ProgramsAndFeatures.SearchEditBoxInfo, new RecordItemIndex(2));
            repo.ProgramsAndFeatures.SearchEditBox.PressKeys("microsoft{Space}SQL{Space}2012");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ProgramsAndFeatures.Row0.MicrosoftSQLServer2012NativeClient'", repo.ProgramsAndFeatures.Row0.MicrosoftSQLServer2012NativeClientInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.ProgramsAndFeatures.Row0.MicrosoftSQLServer2012NativeClientInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProgramsAndFeatures.Row0.MicrosoftSQLServer2012NativeClient' at Center.", repo.ProgramsAndFeatures.Row0.MicrosoftSQLServer2012NativeClientInfo, new RecordItemIndex(4));
            repo.ProgramsAndFeatures.Row0.MicrosoftSQLServer2012NativeClient.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ProgramsAndFeatures.ButtonUninstall'", repo.ProgramsAndFeatures.ButtonUninstallInfo, new ActionTimeout(10000), new RecordItemIndex(5));
            repo.ProgramsAndFeatures.ButtonUninstallInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProgramsAndFeatures.ButtonUninstall' at Center.", repo.ProgramsAndFeatures.ButtonUninstallInfo, new RecordItemIndex(6));
            repo.ProgramsAndFeatures.ButtonUninstall.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ProgramsAndFeatures.ButtonYes'", repo.ProgramsAndFeatures.ButtonYesInfo, new ActionTimeout(10000), new RecordItemIndex(7));
            repo.ProgramsAndFeatures.ButtonYesInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProgramsAndFeatures.ButtonYes' at Center.", repo.ProgramsAndFeatures.ButtonYesInfo, new RecordItemIndex(8));
            repo.ProgramsAndFeatures.ButtonYes.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
