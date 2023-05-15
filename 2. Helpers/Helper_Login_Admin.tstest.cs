using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.TelerikUI.Blazor;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace EXCELSIOR_AuditTrail
{

    public class Helper_Login_Admin : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"New Coded Step")]
        public void VariableTest_CodedStep()
        {
        Log.WriteLine(Global_Variables.Username);
        Log.WriteLine(Global_Variables.Password);
        Log.WriteLine(Global_Variables.URL);
        Log.WriteLine(Global_Variables.Homepage);
        }
    
    
        [CodedStep(@"Enter text '' in 'PasswordLogin'")]
        public void VariableTest_CodedStep2()
        {
            // Enter text '' in 'PasswordLogin'
            Actions.SetText(Pages.ExcelsiorLogin.PasswordLogin, Global_Variables.Password);
            
        }
    
        [CodedStep(@"Wait '5000' msec for url:''")]
        public void LoginHelper_CodedStep()
        {
            // Wait '50000' msec for url:''
            ActiveBrowser.WaitForUrl(Global_Variables.Homepage, true, 50000);
            
        }
    
        [CodedStep(@"Navigate to : 'https://excelsiorqa.meritcro.com/#/login'")]
        public void LoginHelper_CodedStep1()
        {
            // Navigate to : 'https://excelsiorqa.meritcro.com/#/login'
            ActiveBrowser.NavigateTo(Global_Variables.URL, true);
            
        }
    
        [CodedStep(@"Enter text '' in 'UsernameInput'")]
        public void Helper_Login_Admin_CodedStep()
        {
            // Enter text '' in 'UsernameInput'
            Actions.SetText(Pages.ExcelsiorLogin0.UsernameInput, Global_Variables.Username);
            
        }
    }
}
