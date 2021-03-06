//Copyright (C) 2002 Microsoft Corporation

//All rights reserved.

//THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 

//EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 

//MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.

//Requires the Trial or Release version of Visual Studio .NET Professional (or greater).
using System;
using System.Windows.Forms;
using System.Drawing;


public class frmImageViewer: System.Windows.Forms.Form {

#region " Windows Form Designer generated code "

    public frmImageViewer () {

        //This call is required by the Windows Form Designer.
        InitializeComponent();
        //Add any initialization after the InitializeComponent() call
    }

    //Form overrides dispose to clean up the component list.

    protected override void Dispose(bool disposing) {
        if (disposing) {
            if (components != null)
			{
                components.Dispose();

            }

        }

        base.Dispose(disposing);
    }

    //Required by the Windows Form Designer

    private System.ComponentModel.IContainer components = null;

    //NOTE: The following procedure is required by the Windows Form Designer

    //It can be modified using the Windows Form Designer.  

    //Do not modify it using the code editor.

    private System.Windows.Forms.Label lblImageFilename;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.PictureBox picImage;

    private void InitializeComponent() {

        this.picImage = new System.Windows.Forms.PictureBox();
        this.lblImageFilename = new System.Windows.Forms.Label();
        this.btnClose = new System.Windows.Forms.Button();
        this.SuspendLayout();

        //
        //picImage
        //

        this.picImage.BackColor = System.Drawing.SystemColors.Window;

        this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

        this.picImage.Location = new System.Drawing.Point(13, 16);

        this.picImage.Name = "picImage";

        this.picImage.Size = new System.Drawing.Size(392, 248);

        this.picImage.TabIndex = 0;

        this.picImage.TabStop = false;

        //
        //lblImageFilename
        //

        this.lblImageFilename.Location = new System.Drawing.Point(8, 272);

        this.lblImageFilename.Name = "lblImageFilename";

        this.lblImageFilename.Size = new System.Drawing.Size(400, 32);

        this.lblImageFilename.TabIndex = 1;

        this.lblImageFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        //

        //btnClose

        //

        this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        this.btnClose.Location = new System.Drawing.Point(330, 314);

        this.btnClose.Name = "btnClose";

        this.btnClose.TabIndex = 2;

        this.btnClose.Text = "Close";

        //

        //frmImageViewer

        //

        this.AcceptButton = this.btnClose;

        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);

        this.CancelButton = this.btnClose;

        this.ClientSize = new System.Drawing.Size(416, 350);

        this.Controls.AddRange(new System.Windows.Forms.Control[] {this.btnClose, this.lblImageFilename, this.picImage});

        this.MaximizeBox = false;

        this.MinimizeBox = false;

        this.Name = "frmImageViewer";

        this.ShowInTaskbar = false;

        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        this.Text = "frmImageViewer";

        this.ResumeLayout(false);

		this.btnClose.Click +=new EventHandler(btnClose_Click);

    }

#endregion

    // This method overloads the default Show method so that an argument

    // can be passed for displaying the image based on a Stream returned

    // by GetHttpStream() on frmMain.

    public void Show(string strImgSrc)
	{

        frmMain fMain = new frmMain();

            try {

                // Set the PictureBox Image property to the Image generated by
                // the Http response stream.

                picImage.Image = Image.FromStream(fMain.GetHttpStream(strImgSrc));
           } 
		catch(Exception exp)
			{
				MessageBox.Show(exp.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        picImage.SizeMode = PictureBoxSizeMode.CenterImage;
        lblImageFilename.Text = strImgSrc;
        this.Show();
        Application.DoEvents();
    }

    // the "Close" button Click event. Hides the Form.

    private void btnClose_Click(object sender, System.EventArgs e)
	{
        this.Hide();

    }

}

