/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 16/04/2024
 * Time: 7:38 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C__Winform___Login_SignUp
{
	partial class SignUpForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl3SFusername;
		private System.Windows.Forms.TextBox txtb2SFusername;
		private System.Windows.Forms.Label lbl6SFconfirmpass;
		private System.Windows.Forms.TextBox txtb4SFconfirmpass;
		private System.Windows.Forms.Button btn1SFbacktoLF;
		private System.Windows.Forms.Label lbl1SFsignup;
		private System.Windows.Forms.Label lbl5SFPWNote;
		private System.Windows.Forms.Label lbl4SFpassword;
		private System.Windows.Forms.TextBox txtb3SFpassword;
		private System.Windows.Forms.Button btn1SFRegisterAccount;
		private System.Windows.Forms.CheckBox checkBox1ShowPass;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl3SFusername = new System.Windows.Forms.Label();
			this.txtb2SFusername = new System.Windows.Forms.TextBox();
			this.lbl6SFconfirmpass = new System.Windows.Forms.Label();
			this.txtb4SFconfirmpass = new System.Windows.Forms.TextBox();
			this.btn1SFbacktoLF = new System.Windows.Forms.Button();
			this.lbl1SFsignup = new System.Windows.Forms.Label();
			this.lbl5SFPWNote = new System.Windows.Forms.Label();
			this.lbl4SFpassword = new System.Windows.Forms.Label();
			this.txtb3SFpassword = new System.Windows.Forms.TextBox();
			this.btn1SFRegisterAccount = new System.Windows.Forms.Button();
			this.checkBox1ShowPass = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lbl3SFusername
			// 
			this.lbl3SFusername.Location = new System.Drawing.Point(58, 62);
			this.lbl3SFusername.Name = "lbl3SFusername";
			this.lbl3SFusername.Size = new System.Drawing.Size(100, 14);
			this.lbl3SFusername.TabIndex = 32;
			this.lbl3SFusername.Text = "Username";
			// 
			// txtb2SFusername
			// 
			this.txtb2SFusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtb2SFusername.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtb2SFusername.Location = new System.Drawing.Point(58, 79);
			this.txtb2SFusername.Name = "txtb2SFusername";
			this.txtb2SFusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtb2SFusername.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txtb2SFusername.Size = new System.Drawing.Size(206, 20);
			this.txtb2SFusername.TabIndex = 31;
			this.txtb2SFusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl6SFconfirmpass
			// 
			this.lbl6SFconfirmpass.Location = new System.Drawing.Point(58, 175);
			this.lbl6SFconfirmpass.Name = "lbl6SFconfirmpass";
			this.lbl6SFconfirmpass.Size = new System.Drawing.Size(100, 14);
			this.lbl6SFconfirmpass.TabIndex = 29;
			this.lbl6SFconfirmpass.Text = "Confirm Password";
			// 
			// txtb4SFconfirmpass
			// 
			this.txtb4SFconfirmpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtb4SFconfirmpass.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtb4SFconfirmpass.Location = new System.Drawing.Point(60, 192);
			this.txtb4SFconfirmpass.Name = "txtb4SFconfirmpass";
			this.txtb4SFconfirmpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtb4SFconfirmpass.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txtb4SFconfirmpass.Size = new System.Drawing.Size(205, 20);
			this.txtb4SFconfirmpass.TabIndex = 28;
			this.txtb4SFconfirmpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtb4SFconfirmpass.UseSystemPasswordChar = true;
			// 
			// btn1SFbacktoLF
			// 
			this.btn1SFbacktoLF.BackColor = System.Drawing.Color.LightCoral;
			this.btn1SFbacktoLF.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
			this.btn1SFbacktoLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1SFbacktoLF.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn1SFbacktoLF.Location = new System.Drawing.Point(60, 283);
			this.btn1SFbacktoLF.Name = "btn1SFbacktoLF";
			this.btn1SFbacktoLF.Size = new System.Drawing.Size(206, 27);
			this.btn1SFbacktoLF.TabIndex = 27;
			this.btn1SFbacktoLF.Text = "Back to Login";
			this.btn1SFbacktoLF.UseVisualStyleBackColor = false;
			this.btn1SFbacktoLF.Click += new System.EventHandler(this.Btn1SFbacktoLFClick);
			// 
			// lbl1SFsignup
			// 
			this.lbl1SFsignup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lbl1SFsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1SFsignup.Location = new System.Drawing.Point(25, 19);
			this.lbl1SFsignup.Name = "lbl1SFsignup";
			this.lbl1SFsignup.Size = new System.Drawing.Size(125, 31);
			this.lbl1SFsignup.TabIndex = 26;
			this.lbl1SFsignup.Text = "Sign Up";
			this.lbl1SFsignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl5SFPWNote
			// 
			this.lbl5SFPWNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl5SFPWNote.Location = new System.Drawing.Point(60, 146);
			this.lbl5SFPWNote.Name = "lbl5SFPWNote";
			this.lbl5SFPWNote.Size = new System.Drawing.Size(204, 29);
			this.lbl5SFPWNote.TabIndex = 25;
			this.lbl5SFPWNote.Text = "Use 8 or more characters with a mix of letters, numbers, and symbols (e.g. !@#$%^" +
	"&*).";
			// 
			// lbl4SFpassword
			// 
			this.lbl4SFpassword.Location = new System.Drawing.Point(59, 106);
			this.lbl4SFpassword.Name = "lbl4SFpassword";
			this.lbl4SFpassword.Size = new System.Drawing.Size(100, 14);
			this.lbl4SFpassword.TabIndex = 24;
			this.lbl4SFpassword.Text = "Password";
			// 
			// txtb3SFpassword
			// 
			this.txtb3SFpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtb3SFpassword.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtb3SFpassword.Location = new System.Drawing.Point(59, 123);
			this.txtb3SFpassword.Name = "txtb3SFpassword";
			this.txtb3SFpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtb3SFpassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txtb3SFpassword.Size = new System.Drawing.Size(205, 20);
			this.txtb3SFpassword.TabIndex = 23;
			this.txtb3SFpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtb3SFpassword.UseSystemPasswordChar = true;
			// 
			// btn1SFRegisterAccount
			// 
			this.btn1SFRegisterAccount.BackColor = System.Drawing.Color.LightCoral;
			this.btn1SFRegisterAccount.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
			this.btn1SFRegisterAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1SFRegisterAccount.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn1SFRegisterAccount.Location = new System.Drawing.Point(60, 250);
			this.btn1SFRegisterAccount.Name = "btn1SFRegisterAccount";
			this.btn1SFRegisterAccount.Size = new System.Drawing.Size(206, 27);
			this.btn1SFRegisterAccount.TabIndex = 33;
			this.btn1SFRegisterAccount.Text = "Register Account";
			this.btn1SFRegisterAccount.UseVisualStyleBackColor = false;
			this.btn1SFRegisterAccount.Click += new System.EventHandler(this.Btn1SFRegisterAccountClick);
			// 
			// checkBox1ShowPass
			// 
			this.checkBox1ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1ShowPass.Location = new System.Drawing.Point(60, 218);
			this.checkBox1ShowPass.Name = "checkBox1ShowPass";
			this.checkBox1ShowPass.Size = new System.Drawing.Size(124, 20);
			this.checkBox1ShowPass.TabIndex = 34;
			this.checkBox1ShowPass.Text = "Show Password";
			this.checkBox1ShowPass.UseVisualStyleBackColor = true;
			this.checkBox1ShowPass.CheckedChanged += new System.EventHandler(this.CheckBox1ShowPassCheckedChanged);
			// 
			// SignUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(320, 338);
			this.Controls.Add(this.checkBox1ShowPass);
			this.Controls.Add(this.btn1SFRegisterAccount);
			this.Controls.Add(this.lbl3SFusername);
			this.Controls.Add(this.txtb2SFusername);
			this.Controls.Add(this.lbl6SFconfirmpass);
			this.Controls.Add(this.txtb4SFconfirmpass);
			this.Controls.Add(this.btn1SFbacktoLF);
			this.Controls.Add(this.lbl1SFsignup);
			this.Controls.Add(this.lbl5SFPWNote);
			this.Controls.Add(this.lbl4SFpassword);
			this.Controls.Add(this.txtb3SFpassword);
			this.Name = "SignUpForm";
			this.Text = "SignUpForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
