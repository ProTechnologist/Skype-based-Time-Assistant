﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeAssistant {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class App : global::System.Configuration.ApplicationSettingsBase {
        
        private static App defaultInstance = ((App)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new App())));
        
        public static App Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Username {
            get {
                return ((string)(this["Username"]));
            }
            set {
                this["Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RoomName {
            get {
                return ((string)(this["RoomName"]));
            }
            set {
                this["RoomName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DefaultAction {
            get {
                return ((int)(this["DefaultAction"]));
            }
            set {
                this["DefaultAction"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DayEndSummaryToClipboard {
            get {
                return ((bool)(this["DayEndSummaryToClipboard"]));
            }
            set {
                this["DayEndSummaryToClipboard"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IncludeMeetingBreaks {
            get {
                return ((bool)(this["IncludeMeetingBreaks"]));
            }
            set {
                this["IncludeMeetingBreaks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ConvertDayEndSummarytoPastTense {
            get {
                return ((bool)(this["ConvertDayEndSummarytoPastTense"]));
            }
            set {
                this["ConvertDayEndSummarytoPastTense"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(o) Update:")]
        public string UpdateFormat {
            get {
                return ((string)(this["UpdateFormat"]));
            }
            set {
                this["UpdateFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RemoveDuplicatedUpdates {
            get {
                return ((bool)(this["RemoveDuplicatedUpdates"]));
            }
            set {
                this["RemoveDuplicatedUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableHourlyReminder {
            get {
                return ((bool)(this["EnableHourlyReminder"]));
            }
            set {
                this["EnableHourlyReminder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("05")]
        public string ShiftStartHour {
            get {
                return ((string)(this["ShiftStartHour"]));
            }
            set {
                this["ShiftStartHour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public string ShiftStartMinute {
            get {
                return ((string)(this["ShiftStartMinute"]));
            }
            set {
                this["ShiftStartMinute"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PM")]
        public string ShiftStartTT {
            get {
                return ((string)(this["ShiftStartTT"]));
            }
            set {
                this["ShiftStartTT"] = value;
            }
        }
    }
}