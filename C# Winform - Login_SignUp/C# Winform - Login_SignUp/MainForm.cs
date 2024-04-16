/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 16/04/2024
 * Time: 7:35 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C__Winform___Login_SignUp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void Btn1LoginClick(object sender, EventArgs e)
		{
			//get the username and password data from the sign up form
			string username = SignUpForm.Username;
			string password = SignUpForm.Password;
			
			//if else statement to check if the user log the same username and password, and check if the username and pass words is not empty
			if (username != null && password != null && username.Equals(txtb1Username.Text) && password.Equals(txtb2Password.Text))
			{
				MessageBox.Show("Login Successful!");
				txtb1Username.Text = "";
        		txtb2Password.Text = "";
			}
			else
			{
				MessageBox.Show("Invalid username or password. Please try again.");
			}
		}
		
		void CheckBox1ShowPassCheckedChanged(object sender, EventArgs e)
		{
			//shows password when it is check
			if (checkBox1ShowPass.Checked)
			{
				txtb2Password.UseSystemPasswordChar = false;
			}
			else
			{
				txtb2Password.UseSystemPasswordChar = true;
			}
		}
		
		private void Btn2SignUpClick(object sender, EventArgs e)
		{
			//this calls the sign up form, after the sign up form appears, the login/main form will be hidden
			SignUpForm signUpForm = new SignUpForm();
			this.Hide();
			signUpForm.ShowDialog();
			this.Show();
		}
		
		
	}
}
