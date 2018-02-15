using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Globalization;
using System.Diagnostics;
using System.Configuration;
using System.Data.SqlClient;

namespace TAS_Stock
{
    public partial class DataBaseBackUp : Form
       
    {
       static string conn_String = ConfigurationManager.ConnectionStrings["StockDB"].ConnectionString;
        static string conn_master_String = ConfigurationManager.ConnectionStrings["MasterDB"].ConnectionString;
        public DataBaseBackUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Restore your DataBase.\n By using this section you can loss your current state. \n We recommend take your backup first. ", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.CheckFileExists = true;
                    openFileDialog.AddExtension = true;
                    openFileDialog.Multiselect = true;
                    openFileDialog.Filter = "Sql File (*.bak)|*.bak";

                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        foreach (string fileName in openFileDialog.FileNames)
                        {
                            string onlyfilname = Path.GetFileName(fileName);
                            string filepath = Path.GetFullPath(fileName).Replace(onlyfilname, "");
                            RestoreDatabase("StockDB", fileName);
                        }

                        logOut();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void logOut()
        {
            this.Hide();
            FORM_HOME FH = new FORM_HOME();
            FH.Closed += (s, args) => this.Close();
            FH.Close();
            FORM_LOGIN a = new FORM_LOGIN();
            a.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Sql File (*.bak)|*.bak";
                    saveFileDialog1.Title = "Save an bak File";
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName != "")
                    {
                    Cursor.Current = Cursors.WaitCursor;
                        string backUpName = saveFileDialog1.FileName.Replace(Path.GetExtension(saveFileDialog1.FileName), "") + "_TA_STOCK_" + DateTime.Now.ToString("dd-MM-yyyyhhmmssff") + Path.GetExtension(saveFileDialog1.FileName);
                        BackupLocalDatabase(conn_String, "StockDB", backUpName);
                        MessageBox.Show("Back Up Created Successfully.","Backup Restored",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }

        #region Database backup

        public static void RestoreDatabase(string dbname, string backUpFile)
        {
            try
            {
               
                    SqlConnection connection = new SqlConnection(conn_master_String);
                    ServerConnection con = new ServerConnection(connection);
                    Server server = new Server(con);
                    Restore destination = new Restore();
                    destination.Action = RestoreActionType.Database;
                    destination.Database = dbname;
                    BackupDeviceItem source = new BackupDeviceItem(backUpFile, DeviceType.File);
                    destination.Devices.Add(source);
                    if (server.Databases.Contains(dbname))
                    {
                        Trace.TraceInformation("Database exists; killing active connections (there shouldn't be any)...");
                        server.KillAllProcesses(dbname);
                        server.Databases[dbname].Drop();
                        Trace.TraceInformation("Active connections killed and database dropped.");
                    }
                    destination.ReplaceDatabase = true;

                    destination.SqlRestore(server);
                    MessageBox.Show("Back Up Restore Successfully.", "Database Restoring Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        protected static void BackupLocalDatabase(string serverInstance, string databaseName, string databaseBackupFileName)
        {
            SqlConnection connection = new SqlConnection(serverInstance);
            var serverConnection = new ServerConnection(connection);
            var server = new Server(serverConnection);

            try
            {
                string actualDBName = "";
                foreach (Database _db in server.Databases)
                {
                    if (_db.Name.ToUpper().Contains(databaseName.ToUpper()))
                    {
                        actualDBName = _db.Name;
                    }
                }
                databaseName = actualDBName;
                if (server.Databases.Contains(databaseName) == false)
                {
                    throw new ArgumentException("database does not exist on server");
                }

                var timestamp = DateTime.UtcNow.ToString("u", CultureInfo.InvariantCulture);
                var description = string.Format(CultureInfo.InvariantCulture, "Backup of {0} on {1}", databaseName, timestamp);

                var backup = new Backup()
                {
                    Database = databaseName,
                    Action = BackupActionType.Database,
                    BackupSetDescription = description,
                    BackupSetName = description,
                    Incremental = false
                };

                // delete any backup we already have
                if (File.Exists(databaseBackupFileName) == true)
                {
                    File.Delete(databaseBackupFileName);
                }

                var device = new BackupDeviceItem(databaseBackupFileName, DeviceType.File);
                backup.Devices.Add(device);

                backup.PercentComplete += backup_PercentComplete;
                backup.SqlBackup(server);
                backup.PercentComplete -= backup_PercentComplete;

                serverConnection.Disconnect();
            }
            catch (SmoException ex)
            {
                Trace.TraceError("SmoException " + ex);
                throw ex;
            }
            catch (IOException ex)
            {
                Trace.TraceError("IOException " + ex);
                throw ex;
            }
        }
        #endregion


        static void backup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            Trace.TraceInformation("{0}", e.Message);
        }

        private void DataBaseBackUp_Load(object sender, EventArgs e)
        {
            if (LogginInfo.UserType== "SuperAdmin")
            {
                button2.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.TrunateTableBySuperAdmin();
            MessageBox.Show("Table Truncated ", "DataBase Table", MessageBoxButtons.OK);
        }

        // protected static bool CheckDatabaseExists(string serverInstance, string databaseName)
        // {
        //     var serverConnection = new ServerConnection(serverInstance);
        //     var server = new Server(serverConnection);

        //     return server.Databases.Contains(databaseName);
        // }
        // private int BackupByQuery(string databaseName, string restoreFilePath){

        //     SqlConnection connection = new SqlConnection("");
        //     try
        //     {
        //         if (connection.State != ConnectionState.Open)
        //         {
        //             connection.Open();
        //         }
        //         //var serverConnection = new ServerConnection(connection);
        //         //var server = new Server(serverConnection);
        //         //string actualDBName = "";
        //         //foreach (Database _db in server.Databases)
        //         //{
        //         //    if (_db.Name.ToUpper().Contains(databaseName.ToUpper()))
        //         //    {
        //         //        actualDBName = _db.Name;
        //         //    }
        //         //}
        //         //databaseName = actualDBName;
        //         string restoreDB_Query = "IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'" + databaseName + "') DROP DATABASE " + databaseName + " RESTORE DATABASE " + databaseName + " FROM DISK = '" + restoreFilePath + "'  WITH REPLACE";
        //         SqlCommand cmd = new SqlCommand(restoreDB_Query, connection);
        //         return cmd.ExecuteNonQuery();
        //     }
        //     catch (Exception ex)
        //     {
        //         if (connection.State == ConnectionState.Open)
        //         {
        //             connection.Close();
        //             connection.Dispose();
        //         }
        //         throw ex;
        //     }
        //     finally {
        //         if (connection.State == ConnectionState.Open)
        //         {
        //             connection.Close();
        //             connection.Dispose();
        //         }
        //     }
        // }

        // protected static void RestoreLocalDatabase(string databaseBackupFileName, string destinationDirectory, string serverInstance, string databaseName)
        // {
        //     SqlConnection connection = new SqlConnection(serverInstance);
        //     var serverConnection = new ServerConnection(connection);
        //     var server = new Server(serverConnection);

        //     Trace.TraceInformation("Restoring backup file {0} to database {1}", databaseBackupFileName, databaseName);

        //     try
        //     {
        //         string actualDBName = "";
        //         foreach (Database _db in server.Databases)
        //         {
        //             if (_db.Name.ToUpper().Contains(databaseName.ToUpper()))
        //             {
        //                 actualDBName = _db.Name;
        //             }
        //         }
        //         databaseName = actualDBName;
        //         // see if the database exists, and if it does, close it down and drop it
        //         if (server.Databases.Contains(databaseName))
        //         {
        //             Trace.TraceInformation("Database exists; killing active connections (there shouldn't be any)...");
        //             server.KillAllProcesses(databaseName);
        //             server.Databases[databaseName].Drop();
        //             Trace.TraceInformation("Active connections killed and database dropped.");
        //         }

        //         // set up the command
        //         var restore = new Restore()
        //         {
        //             PercentCompleteNotification = 10,
        //             Database = databaseName,
        //             NoRecovery = false,
        //             KeepReplication = false,
        //             ReplaceDatabase = true,
        //             Restart = true
        //         };
        //         restore.Devices.AddDevice(databaseBackupFileName, DeviceType.File);
        //         restore.PercentComplete += restore_PercentComplete;

        //         // relocate the source files from the backup to the local location
        //         var files = restore.ReadFileList(server);
        //         foreach (DataRow dataRow in files.Rows)
        //         {
        //             var physicalName = dataRow["PhysicalName"].ToString();
        //             var logicalName = dataRow["LogicalName"].ToString();
        //             physicalName = Path.Combine(destinationDirectory, Path.GetFileName(physicalName));
        //             restore.RelocateFiles.Add(new RelocateFile(logicalName, physicalName));

        //             Trace.TraceInformation("Relocating physical DB file {0} to physical file {1}", dataRow["LogicalName"].ToString(), physicalName);
        //         }

        //         // do the restore
        //         Trace.TraceInformation("Beginning restore...");

        //         restore.SqlRestore(server);
        //         restore.Wait();

        //         Trace.TraceInformation("Restore complete.");

        //         restore.PercentComplete -= restore_PercentComplete;

        //         // general database housekeeping
        //         Trace.TraceInformation("Shrinking database (just to be sure)...");
        //         server.Databases[databaseName].RecoveryModel = RecoveryModel.Simple;
        //         server.Databases[databaseName].Shrink(1, ShrinkMethod.TruncateOnly);
        //         Trace.TraceInformation("Shrink complete.");

        //         serverConnection.Disconnect();
        //     }
        //     catch (SmoException ex)
        //     {
        //         Trace.TraceError("SmoException " + ex);
        //         throw;
        //     }
        //     catch (IOException ex)
        //     {
        //         Trace.TraceError("IOException " + ex);
        //         throw;
        //     }

        //     Trace.TraceInformation("Completed restoration of backup file {0} to database {1}", databaseBackupFileName, databaseName);
        // }
        // public void RestoreDatabase(String databaseName, String filePath,
        //String serverName,
        //String dataFilePath, String logFilePath)
        // {
        //     Restore sqlRestore = new Restore();

        //     BackupDeviceItem deviceItem = new BackupDeviceItem(filePath, DeviceType.File);
        //     sqlRestore.Devices.Add(deviceItem);
        //     sqlRestore.Database = databaseName;

        //     ServerConnection connection = new ServerConnection(serverName);
        //     Server sqlServer = new Server(connection);

        //     Database db = sqlServer.Databases[databaseName];
        //     sqlRestore.Action = RestoreActionType.Database;
        //     String dataFileLocation = dataFilePath + databaseName + ".mdf";
        //     String logFileLocation = logFilePath + databaseName + "_Log.ldf";
        //     db = sqlServer.Databases[databaseName];
        //     RelocateFile rf = new RelocateFile(databaseName, dataFileLocation);

        //     sqlRestore.RelocateFiles.Add(new RelocateFile(databaseName, dataFileLocation));
        //     sqlRestore.RelocateFiles.Add(new RelocateFile(databaseName + "_log", logFileLocation));
        //     sqlRestore.ReplaceDatabase = true;
        //     //sqlRestore.Complete += new ServerMessageEventHandler(sqlRestore_Complete);
        //     //sqlRestore.PercentCompleteNotification = 10;
        //     //sqlRestore.PercentComplete +=
        //     //   new PercentCompleteEventHandler(sqlRestore_PercentComplete);

        //     sqlRestore.SqlRestore(sqlServer);
        //     db = sqlServer.Databases[databaseName];
        //     db.SetOnline();
        //     sqlServer.Refresh();
        // }
        // static void restore_PercentComplete(object sender, PercentCompleteEventArgs e)
        // {
        //     Trace.TraceInformation("{0}", e.Message);
        // }

        // private void DataBaseBackUp_Load(object sender, EventArgs e)
        // {

        // }
    }
}
