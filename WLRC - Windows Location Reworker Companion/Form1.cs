using System;
using System.Windows.Forms;
using System.IO;

//credit to http://www.trytoprogram.com/batch-file-commands/ for batch command descriptions

namespace WLRC___Windows_Location_Reworker_Companion
{
	public partial class Form1 : Form
	{
		string directory_path;
		string selected_node_path;
		string selected_filename;

		public Form1() { InitializeComponent(); }
		
		private void Form1_Load(object sender, EventArgs e)
		{
			ListViewBox_bat_commands.Columns[0].Width = -2;
			ListViewBox_bat_commands.Columns[1].Width = -2;
		}

		private void Button_select_directory_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog fbd = new FolderBrowserDialog())
			{
				fbd.Description = "Select a Directory";

				if (fbd.ShowDialog() == DialogResult.OK)
				{
					label_directory.Text = fbd.SelectedPath;
					directory_path = fbd.SelectedPath;
					label_directory.Visible = true;
				}
			}
			ListDirectory(TreeView, directory_path);
		}

		private void ListDirectory(TreeView treeView, string path)
		{
			treeView.Nodes.Clear();

			var rootDirectoryInfo = new DirectoryInfo(path);
			treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
		}

		private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
		{
			var directoryNode = new TreeNode(directoryInfo.Name);

			foreach (var directory in directoryInfo.GetDirectories())
				directoryNode.Nodes.Add(CreateDirectoryNode(directory));

			foreach (var file in directoryInfo.GetFiles())
				directoryNode.Nodes.Add(new TreeNode(file.Name));

			return directoryNode;
		}

		private void ComboBox_operation_SelectedIndexChanged(object sender, EventArgs e)
		{
			//CD
			if (ComboBox_operation.SelectedIndex == 0)
			{
				button_usage.Enabled = true;
				label_operation_info.Text = 
					"The batch command CD helps in navigating through different directories and changing directories or displaying current directory.";
			}

			//CMD
			else if (ComboBox_operation.SelectedIndex == 1)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command CMD invokes a new command prompt window.";
			}

			//COPY
			else if (ComboBox_operation.SelectedIndex == 2)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command COPY is used for copying files from one location to another.";
			}

			//DEL
			else if (ComboBox_operation.SelectedIndex == 3)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command DEL is used for deleting files.";
			}

			//EXIT
			else if (ComboBox_operation.SelectedIndex == 4)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command EXIT terminates and exits the console.";
			}

			//MD
			else if (ComboBox_operation.SelectedIndex == 5)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command MD creates a new directory or folder in the working directory.";
			}

			//MORE
			else if (ComboBox_operation.SelectedIndex == 6)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command MORE displays the content of a file line by line.";
			}
			
			//MOVE
			else if (ComboBox_operation.SelectedIndex == 7)
			{

				button_usage.Enabled = true;
				label_operation_info.Text =
					"This batch command moves files from one directory to another, rename the directories and move the directories as well.";
			}

			//PAUSE
			else if (ComboBox_operation.SelectedIndex == 8)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command PAUSE is used for holding the output screen till user enters a variable or a value.";
			}

			//RD
			else if (ComboBox_operation.SelectedIndex == 9)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command RD is used for removing the empty directories, directories with contents or files inside cannot be removed with RD command.";
			}

			//REM
			else if (ComboBox_operation.SelectedIndex == 10)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command REM signifies comments in the batch script.";
			}

			//REN
			else if (ComboBox_operation.SelectedIndex == 11)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command REN is used for renaming files and directories.";
			}

			//TASKLIST
			else if (ComboBox_operation.SelectedIndex == 12)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command TASKLIST lists all the running tasks in the console.";
			}

			//TITLE
			else if (ComboBox_operation.SelectedIndex == 13)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"The batch command TITLE sets new title for output console.";
			}

			//HELP
			else if (ComboBox_operation.SelectedIndex == 14)
			{
				button_usage.Enabled = true;
				label_operation_info.Text =
					"This might be the one of the most important batch file commands because with this HELP" +
					"\ncommand we can know about all the other commands used in batch file or command prompt.";
			}
		}	

		private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			selected_node_path =
				Path.Combine
				(
				Directory.GetParent(directory_path).FullName,
				TreeView.SelectedNode.FullPath
				);

			Clipboard.SetText('"' + selected_node_path + '"' + ' ');

			MessageBox.Show
				(
				"Full node path\n\n" +
				selected_node_path +
				"\n\nHas been added to your clipboard"
				);
		}

		private void Button_submit_command_Click(object sender, EventArgs e)
		{
			var item = new ListViewItem(new[] { ComboBox_operation.Text, textbox_command.Text.TrimEnd() });
			ListViewBox_bat_commands.Items.Add(item);

			button_export.Enabled = true;
		}

		private void Button_export_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog
			{
				Title = "Save .bat File",
				RestoreDirectory = true,
				DefaultExt = "bat",
				Filter = "Batch files (*.bat)|*.bat|All files (*.*)|*.*",
				FilterIndex = 1,
			};

			if (sfd.ShowDialog() == DialogResult.OK) selected_filename = sfd.FileName;

			using (var sw = new StreamWriter(selected_filename))
			{
				foreach (ListViewItem item in ListViewBox_bat_commands.Items)
				{
					sw.WriteLine($"{item.SubItems[0].Text} {item.SubItems[1].Text}");
				}
			}

		}

		private void Button_usage_Click(object sender, EventArgs e)
		{
			//CD
			if (ComboBox_operation.SelectedIndex == 0)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					":: CD without any parameters displays the current working directory\n" +
					"CD\n" +
					"::Changing to the parent directory one level up\n" +
					"CD..CD\n" +
					"::Changing the path to Programs\n" +
					"CD\\Programs\n" +
					"CD\n" +
					"pause\n\n"
					, "Usage");
			}

			//CMD
			else if (ComboBox_operation.SelectedIndex == 1)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"CMD"
					, "Usage");
			}

			//COPY
			else if (ComboBox_operation.SelectedIndex == 2)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"::For copying from one drive to another - xyz.txt from D:\\ to E:\\\n" +
					"COPY D:\\xyz.txt E:\\\n\n" +
					"::If file has whitepace between name - use double quote\n" +
					"COPY \"D:\\my file.txt\" E:\\"
					, "Usage");
			}

			//DEL
			else if (ComboBox_operation.SelectedIndex == 3)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					":: To delete a single file xyz.txt\n" +
					"DEL D:\\xyz.txt\n\n" +
					":: To delete all the files of .txt extensions and ask for confirmation before deleting\n" +
					"DEL /p/s D:\\*.txt\n\n" +
					":: Remove /p to delete without confirmation\n" +
					"DEL /s D:\\*.txt"
					, "Usage");
			}

			//EXIT
			else if (ComboBox_operation.SelectedIndex == 4)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"echo HI\n" +
					"EXIT"
					, "Usage");
			}

			//MD
			else if (ComboBox_operation.SelectedIndex == 5)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"MD abc"
					, "Usage");
			}

			//MORE
			else if (ComboBox_operation.SelectedIndex == 6)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"MORE D:\\example.txt"
					, "Usage");
			}

			//MOVE
			else if (ComboBox_operation.SelectedIndex == 7)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					":: To move xyz.txt from dir1 to dir2\n" +
					"MOVE C:\\dir1\\xyz.txt C:\\dir2\n\n" +
					":: To rename directory dir1 to dir2\n" +
					"MOVE C:\\Program\\dir1 C:\\Program\\dir2\n\n" +
					":: To move directory dir1 from D:\\ to D:\\music\n" +
					"MOVE D:\\dir1 D:\\music\\"
					, "Usage");
			}

			//PAUSE
			else if (ComboBox_operation.SelectedIndex == 8)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"ECHO hi\n" +
					"PAUSE"
					, "Usage");
			}

			//RD
			else if (ComboBox_operation.SelectedIndex == 9)
			{
				MessageBox.Show(
					"@echo OFF" +
					":: To remove directory xyz from C:\\>\n" +
					"RD C:\\xyz\n\n" +
					":: To remove multiple directories from working location\n" +
					"RD dir1 dir2"
					, "Usage");
			}

			//REM
			else if (ComboBox_operation.SelectedIndex == 10)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"REM This is a comment"
					, "Usage");
			}

			//REN
			else if (ComboBox_operation.SelectedIndex == 11)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					":: To rename x.php to y.php\n" +
					"REN C:\\x.php C:\\y.php"
					, "Usage");
			}

			//TASKLIST
			else if (ComboBox_operation.SelectedIndex == 12)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"TASKLIST"
					, "Usage");
			}

			//TITLE
			else if (ComboBox_operation.SelectedIndex == 13)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"TITLE New Console"
					, "Usage");
			}

			//HELP
			else if (ComboBox_operation.SelectedIndex == 14)
			{
				MessageBox.Show(
					"@echo OFF\n" +
					"HELP on its own will display all available commands\n\n" +
					":: You can also type HELP and the command you want to know about\n" +
					"HELP move"
					, "Usage");
			}
		}
	}
}