/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 16/04/2024
 * Time: 7:38 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Winform___Login_SignUp
{
	/// <summary>
	/// Description of SignUpForm.
	/// </summary>
	public partial class SignUpForm : Form
	{
		//these properties are written so that the data from sign up form class will be accessible 
		//from the outside class, like the Main Form class
		//https://www.w3schools.com/cs/cs_properties.php
		public static string Username { get; private set;}
		public static string Password { get; private set;}
		
		public SignUpForm()
		{
			InitializeComponent();
		}
		
		private void Btn1SFRegisterAccountClick(object sender, EventArgs e)
		{
		
			Username = txtb2SFusername.Text; //value of the get property
			Password = txtb3SFpassword.Text; //value of the get property
			
			string confirmPass = txtb4SFconfirmpass.Text;
			
			//character limitation of password
				if (txtb3SFpassword.Text.Length < 8)
				{
					lbl5SFPWNote.Text = "Password is too short.";
					return;
				}
					
			//condition that checks if the user fills up the credentials needed to sign up
			//https://www.geeksforgeeks.org/c-sharp-isnullorempty-method/
			if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(confirmPass))
        		{
					//confirms if password is correct
            		if (Password != confirmPass)
            		{
               			 MessageBox.Show("Passwords do not match. Please try again.");
                		 return;
            		}
            		
            		MessageBox.Show("Sign up successful! You can now log in.");
        		}
        	else
        		{
            		MessageBox.Show("Sign up failed. Please try again.");
        		}
		}
		
		void CheckBox1ShowPassCheckedChanged(object sender, EventArgs e)
		{
			//shows password checkbox
			if (checkBox1ShowPass.Checked)
			{
				txtb3SFpassword.UseSystemPasswordChar = false;
				txtb4SFconfirmpass.UseSystemPasswordChar = false;
			}
			else
			{
				txtb3SFpassword.UseSystemPasswordChar = true;
				txtb4SFconfirmpass.UseSystemPasswordChar = true;
			}
		}
		
		void Btn1SFbacktoLFClick(object sender, EventArgs e)
		{
			this.Close(); //close the form and direct back to the main form
		}
		
	}
}
