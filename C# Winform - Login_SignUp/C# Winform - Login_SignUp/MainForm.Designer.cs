/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 16/04/2024
 * Time: 7:35 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C__Winform___Login_SignUp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl3PWNote;
		private System.Windows.Forms.Button btn2SignUp;
		private System.Windows.Forms.Label lbl4SignUp;
		private System.Windows.Forms.Button btn1Login;
		private System.Windows.Forms.Label lbl3password;
		private System.Windows.Forms.TextBox txtb2Password;
		private System.Windows.Forms.Label lbl2Username;
		private System.Windows.Forms.TextBox txtb1Username;
		private System.Windows.Forms.Label lbl1Login;
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
			this.lbl3PWNote = new System.Windows.Forms.Label();
			this.btn2SignUp = new System.Windows.Forms.Button();
			this.lbl4SignUp = new System.Windows.Forms.Label();
			this.btn1Login = new System.Windows.Forms.Button();
			this.lbl3password = new System.Windows.Forms.Label();
			this.txtb2Password = new System.Windows.Forms.TextBox();
			this.lbl2Username = new System.Windows.Forms.Label();
			this.txtb1Username = new System.Windows.Forms.TextBox();
			this.lbl1Login = new System.Windows.Forms.Label();
			this.checkBox1ShowPass = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lbl3PWNote
			// 
			this.lbl3PWNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl3PWNote.Location = new System.Drawing.Point(64, 155);
			this.lbl3PWNote.Name = "lbl3PWNote";
			this.lbl3PWNote.Size = new System.Drawing.Size(204, 29);
			this.lbl3PWNote.TabIndex = 17;
			this.lbl3PWNote.Text = "Use 8 or more characters with a mix of letters, numbers, and symbols (e.g. !@#$%^" +
	"&*).";
			// 
			// btn2SignUp
			// 
			this.btn2SignUp.BackColor = System.Drawing.Color.LightCoral;
			this.btn2SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2SignUp.Location = new System.Drawing.Point(63, 268);
			this.btn2SignUp.Name = "btn2SignUp";
			this.btn2SignUp.Size = new System.Drawing.Size(205, 27);
			this.btn2SignUp.TabIndex = 16;
			this.btn2SignUp.Text = "Sign Up Here";
			this.btn2SignUp.UseVisualStyleBackColor = false;
			this.btn2SignUp.Click += new System.EventHandler(this.Btn2SignUpClick);
			// 
			// lbl4SignUp
			// 
			this.lbl4SignUp.Location = new System.Drawing.Point(63, 251);
			this.lbl4SignUp.Name = "lbl4SignUp";
			this.lbl4SignUp.Size = new System.Drawing.Size(125, 14);
			this.lbl4SignUp.TabIndex = 15;
			this.lbl4SignUp.Text = "Don\'t have an account?  ";
			// 
			// btn1Login
			// 
			this.btn1Login.BackColor = System.Drawing.Color.LightCoral;
			this.btn1Login.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
			this.btn1Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1Login.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn1Login.Location = new System.Drawing.Point(63, 213);
			this.btn1Login.Name = "btn1Login";
			this.btn1Login.Size = new System.Drawing.Size(205, 27);
			this.btn1Login.TabIndex = 14;
			this.btn1Login.Text = "Login";
			this.btn1Login.UseVisualStyleBackColor = false;
			this.btn1Login.Click += new System.EventHandler(this.Btn1LoginClick);
			// 
			// lbl3password
			// 
			this.lbl3password.Location = new System.Drawing.Point(63, 115);
			this.lbl3password.Name = "lbl3password";
			this.lbl3password.Size = new System.Drawing.Size(100, 14);
			this.lbl3password.TabIndex = 13;
			this.lbl3password.Text = "Password";
			// 
			// txtb2Password
			// 
			this.txtb2Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtb2Password.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtb2Password.Location = new System.Drawing.Point(63, 132);
			this.txtb2Password.Name = "txtb2Password";
			this.txtb2Password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtb2Password.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txtb2Password.Size = new System.Drawing.Size(205, 20);
			this.txtb2Password.TabIndex = 12;
			this.txtb2Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtb2Password.UseSystemPasswordChar = true;
			// 
			// lbl2Username
			// 
			this.lbl2Username.Location = new System.Drawing.Point(63, 65);
			this.lbl2Username.Name = "lbl2Username";
			this.lbl2Username.Size = new System.Drawing.Size(100, 14);
			this.lbl2Username.TabIndex = 11;
			this.lbl2Username.Text = "Username";
			// 
			// txtb1Username
			// 
			this.txtb1Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtb1Username.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtb1Username.Location = new System.Drawing.Point(63, 82);
			this.txtb1Username.Name = "txtb1Username";
			this.txtb1Username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtb1Username.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txtb1Username.Size = new System.Drawing.Size(205, 20);
			this.txtb1Username.TabIndex = 10;
			this.txtb1Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl1Login
			// 
			this.lbl1Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lbl1Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1Login.Location = new System.Drawing.Point(36, 18);
			this.lbl1Login.Name = "lbl1Login";
			this.lbl1Login.Size = new System.Drawing.Size(80, 31);
			this.lbl1Login.TabIndex = 9;
			this.lbl1Login.Text = "Login";
			this.lbl1Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox1ShowPass
			// 
			this.checkBox1ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1ShowPass.Location = new System.Drawing.Point(64, 187);
			this.checkBox1ShowPass.Name = "checkBox1ShowPass";
			this.checkBox1ShowPass.Size = new System.Drawing.Size(124, 20);
			this.checkBox1ShowPass.TabIndex = 18;
			this.checkBox1ShowPass.Text = "Show Password";
			this.checkBox1ShowPass.UseVisualStyleBackColor = true;
			this.checkBox1ShowPass.CheckedChanged += new System.EventHandler(this.CheckBox1ShowPassCheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(320, 338);
			this.Controls.Add(this.checkBox1ShowPass);
			this.Controls.Add(this.lbl3PWNote);
			this.Controls.Add(this.btn2SignUp);
			this.Controls.Add(this.lbl4SignUp);
			this.Controls.Add(this.btn1Login);
			this.Controls.Add(this.lbl3password);
			this.Controls.Add(this.txtb2Password);
			this.Controls.Add(this.lbl2Username);
			this.Controls.Add(this.txtb1Username);
			this.Controls.Add(this.lbl1Login);
			this.Name = "MainForm";
			this.Text = "C# Winform - Login_SignUp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
