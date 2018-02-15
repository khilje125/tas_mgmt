namespace TAS_Stock
{
    partial class ReportTotalReceivable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewerTR = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerTR
            // 
            this.reportViewerTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerTR.LocalReport.ReportEmbeddedResource = "TAS_Stock.TotalReceiveable.rdlc";
            this.reportViewerTR.Location = new System.Drawing.Point(0, 0);
            this.reportViewerTR.Name = "reportViewerTR";
            this.reportViewerTR.ServerReport.BearerToken = null;
            this.reportViewerTR.ShowBackButton = false;
            this.reportViewerTR.ShowExportButton = false;
            this.reportViewerTR.ShowFindControls = false;
            this.reportViewerTR.ShowStopButton = false;
            this.reportViewerTR.ShowZoomControl = false;
            this.reportViewerTR.Size = new System.Drawing.Size(803, 587);
            this.reportViewerTR.TabIndex = 55;
            this.reportViewerTR.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReportTotalReceivable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 587);
            this.Controls.Add(this.reportViewerTR);
            this.Name = "ReportTotalReceivable";
            this.Text = "ReportTotalReceivable";
            this.Load += new System.EventHandler(this.ReportTotalReceivable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTR;
    }
}