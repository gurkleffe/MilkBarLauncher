﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Breath_of_the_Wild_Multiplayer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Link")]
        public string playerName {
            get {
                return ((string)(this["playerName"]));
            }
            set {
                this["playerName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Random")]
        public string background {
            get {
                return ((string)(this["background"]));
            }
            set {
                this["background"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/Images/mainWindowBackground.png")]
        public string actualBackground {
            get {
                return ((string)(this["actualBackground"]));
            }
            set {
                this["actualBackground"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[]")]
        public string serversAdded {
            get {
                return ((string)(this["serversAdded"]));
            }
            set {
                this["serversAdded"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string backgroundDir {
            get {
                return ((string)(this["backgroundDir"]));
            }
            set {
                this["backgroundDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string backgroundExt {
            get {
                return ((string)(this["backgroundExt"]));
            }
            set {
                this["backgroundExt"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string bcmlLocation {
            get {
                return ((string)(this["bcmlLocation"]));
            }
            set {
                this["bcmlLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"{""Name"":""Link"",""Description"":""This model does allow for armor sync."",""IsArmorSync"":true,""Model"":""Jugador1ModelNameLongForASpecificReason"",""BumiiData"":null,""AlternativeModel"":"""",""BustPic"":""/Images/Bust/Link.png"",""BodyPic"":""/Images/Body/Link.png"",""ModelIndex"":0,""HasCustomAction"":false,""Selected"":true,""CustomAction"":null}")]
        public string playerModel {
            get {
                return ((string)(this["playerModel"]));
            }
            set {
                this["playerModel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool playAsModel {
            get {
                return ((bool)(this["playAsModel"]));
            }
            set {
                this["playAsModel"] = value;
            }
        }
    }
}
