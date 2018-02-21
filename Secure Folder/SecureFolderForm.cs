using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Secure_Folder {
	public partial class SecureFolderForm : Form {

		string pathCurrentProgram;
		string pathTopLevel;
		string pathFolder;

		string password = "LOK";

		DirectoryInfo dirSecureFolder;


		public SecureFolderForm() {
			InitializeComponent();

			//Set the variables
			pathCurrentProgram = Directory.GetCurrentDirectory();
			//pathTopLevel = @"d:\Test";
			pathFolder = Path.Combine(pathCurrentProgram, "Secure Folder");
			
			//Create the subfolders
			Directory.CreateDirectory(pathFolder);

			//Create a directory object
			dirSecureFolder = new DirectoryInfo(pathFolder);
		}



		private void ButtonKeyUp(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				CheckPassword();
			}
		}
		private void ClickPasswordCheck(object sender, EventArgs e) {
			CheckPassword();
		}

		private void CheckPassword() {
			if(textBoxPassword.Text.Equals(password)) {
				HideBtn.Enabled = true;
				ShowBtn.Enabled = true;
			}
			else {
				HideBtn.Enabled = false;
				ShowBtn.Enabled = false;
				CreatePopUpMessage("You have entered the wrong password!", "Wrong Password");
			}
		}



		private void ClickFolderHide(object sender, EventArgs e) {
			FolderHide(dirSecureFolder);
		}
		private void ClickFolderShow(object sender, EventArgs e) {
			FolderShow(dirSecureFolder);
		}

		private void FolderHide(DirectoryInfo dirFolder) {
			//dirFolder.Attributes |= FileAttributes.Hidden;
			dirFolder.Attributes = FileAttributes.Hidden;
		}
		private void FolderShow(DirectoryInfo dirFolder) {
			//dirFolder.Attributes &= ~FileAttributes.Hidden;
			dirFolder.Attributes = FileAttributes.Normal;
		}

		private void CreatePopUpMessage(string message, string title) {
			string text = message;
			string caption = title;
			MessageBoxButtons buttons;
			DialogResult result;

			buttons = MessageBoxButtons.OK;
			result = MessageBox.Show(text, caption, buttons);
			/*
			if(result == System.Windows.Forms.DialogResult.Yes) {
				// Closes the parent form.
				this.Close();
			}
			*/
		}
	}
}

/*
//Checks to see if the folder exists
if(!Directory.Exists(dirFolder.FullName)) {
	//Doesn't create any parent directories that might be missing
	Directory.CreateDirectory(dirFolder.Extension);
	CreatePopUpMessage("Folder does not exist.", "No Folder");
}
else {
	CreatePopUpMessage("Folder already exists.", "Folder");
}
*/

/*
private void ClickButton(object sender, EventArgs e) {
			
	// Create a file name for the file you want to create. 
	string fileName = Path.GetRandomFileName();

	// This example uses a random string for the name, but you also can specify
	// a particular name.
	//string fileName = "MyNewFile.txt";

	// Use Combine again to add the file name to the path.
	pathFolder = Path.Combine(pathFolder, fileName);

	// Verify the path that you have constructed.
	Console.WriteLine("Path to my file: {0}\n", pathFolder);

	// Check that the file doesn't already exist. If it doesn't exist, create
	// the file and write integers 0 - 99 to it.
	// DANGER: System.IO.File.Create will overwrite the file if it already exists.
	// This could happen even with random file names, although it is unlikely.
	if(!File.Exists(pathFolder)) {
		using(FileStream fs = File.Create(pathFolder)) {
			for(byte i = 0; i < 100; i++) {
				fs.WriteByte(i);
			}
		}
	}
	else {
		Console.WriteLine("File \"{0}\" already exists.", fileName);
		return;
	}

	// Read and display the data from your file.
	try {
		byte[] readBuffer = File.ReadAllBytes(pathFolder);
		foreach(byte b in readBuffer) {
			Console.Write(b + " ");
		}
		Console.WriteLine();
	}
	catch(IOException ee) {
		Console.WriteLine(ee.Message);
	}


	CreatePopUpMessage("Test", "Title");

	// Keep the console window open in debug mode.
	//System.Console.WriteLine("Press any key to exit.");
	//System.Console.ReadKey();

}
*/
