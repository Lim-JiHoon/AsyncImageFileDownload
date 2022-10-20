
namespace cspOptometry.Views
{
  partial class FrmMyopiaSetting
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyopiaSetting));
      DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.txtMyopiaSaveDir = new DevExpress.XtraEditors.ButtonEdit();
      ((System.ComponentModel.ISupportInitialize)(this.txtMyopiaSaveDir.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("굴림", 9F);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
      this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
      this.labelControl1.Location = new System.Drawing.Point(12, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(101, 20);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "파일 저장 경로";
      // 
      // txtMyopiaSaveDir
      // 
      this.txtMyopiaSaveDir.Location = new System.Drawing.Point(23, 38);
      this.txtMyopiaSaveDir.Name = "txtMyopiaSaveDir";
      editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
      this.txtMyopiaSaveDir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
      this.txtMyopiaSaveDir.Properties.ReadOnly = true;
      this.txtMyopiaSaveDir.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_Properties_ButtonClick);
      this.txtMyopiaSaveDir.Size = new System.Drawing.Size(356, 28);
      this.txtMyopiaSaveDir.TabIndex = 1;
      // 
      // FrmMyopiaSetting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(410, 84);
      this.Controls.Add(this.txtMyopiaSaveDir);
      this.Controls.Add(this.labelControl1);
      this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmMyopiaSetting.IconOptions.Image")));
      this.LookAndFeel.SkinName = "WXI";
      this.LookAndFeel.UseDefaultLookAndFeel = false;
      this.Name = "FrmMyopiaSetting";
      this.Text = "근시퇴행 기능흐름도 설정";
      ((System.ComponentModel.ISupportInitialize)(this.txtMyopiaSaveDir.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.ButtonEdit txtMyopiaSaveDir;
  }
}