﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAS_Stock.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-8Q8ULDG\\SQLEXPRESS;Initial Catalog=StockDB;Integrated Securit" +
            "y=True")]
        public string StockDBConnectionString {
            get {
                return ((string)(this["StockDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=D:\\PROJECT\\TAS_Stock-UPDATED\\T" +
            "AS_Stock\\TAS_Stock\\DB\\STOCKDB.MDF;Integrated Security=True")]
        public string D__PROJECT_TAS_Stock_UPDATED_TAS_Stock_TAS_Stock_DB_STOCKDB_MDFConnectionString {
            get {
                return ((string)(this["D__PROJECT_TAS_Stock_UPDATED_TAS_Stock_TAS_Stock_DB_STOCKDB_MDFConnectionString"]));
            }
        }
    }
}
