/*
 * Created by SharpDevelop.
 * User: Mike
 * Date: 5/21/2014
 * Time: 6:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace hyperdesktop2
{
	partial class frm_Preferences
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Preferences));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_general = new System.Windows.Forms.TabPage();
            this.drop_save_quality = new System.Windows.Forms.ComboBox();
            this.label_save_quality = new System.Windows.Forms.Label();
            this.drop_save_format = new System.Windows.Forms.ComboBox();
            this.label_save_format = new System.Windows.Forms.Label();
            this.btn_browse_save_folder = new System.Windows.Forms.Button();
            this.txt_save_folder = new System.Windows.Forms.TextBox();
            this.check_save_screenshots = new System.Windows.Forms.CheckBox();
            this.tab_behavior = new System.Windows.Forms.TabPage();
            this.check_show_cursor = new System.Windows.Forms.CheckBox();
            this.check_edit_screenshot = new System.Windows.Forms.CheckBox();
            this.check_launch_browser = new System.Windows.Forms.CheckBox();
            this.check_balloon = new System.Windows.Forms.CheckBox();
            this.check_sound_effects = new System.Windows.Forms.CheckBox();
            this.check_copy_links = new System.Windows.Forms.CheckBox();
            this.check_run_at_startup = new System.Windows.Forms.CheckBox();
            this.tab_uploading = new System.Windows.Forms.TabPage();
            this.drop_upload_method = new System.Windows.Forms.ComboBox();
            this.label_upload_method = new System.Windows.Forms.Label();
            this.drop_upload_format = new System.Windows.Forms.ComboBox();
            this.label_update_format = new System.Windows.Forms.Label();
            this.tab_hotkeys = new System.Windows.Forms.TabPage();
            this.txt_hotkey_window = new System.Windows.Forms.TextBox();
            this.label_window_screenshot = new System.Windows.Forms.Label();
            this.txt_hotkey_region = new System.Windows.Forms.TextBox();
            this.label_region_screenshot = new System.Windows.Forms.Label();
            this.txt_hotkey_screenshot = new System.Windows.Forms.TextBox();
            this.label_screenshot = new System.Windows.Forms.Label();
            this.label_hotkeys_instructions = new System.Windows.Forms.Label();
            this.tab_screens = new System.Windows.Forms.TabPage();
            this.btn_reset_screen = new System.Windows.Forms.Button();
            this.numeric_height = new System.Windows.Forms.NumericUpDown();
            this.numeric_width = new System.Windows.Forms.NumericUpDown();
            this.numeric_left = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_screen_y = new System.Windows.Forms.Label();
            this.numeric_top = new System.Windows.Forms.NumericUpDown();
            this.label_screen_x = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_general.SuspendLayout();
            this.tab_behavior.SuspendLayout();
            this.tab_uploading.SuspendLayout();
            this.tab_hotkeys.SuspendLayout();
            this.tab_screens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_top)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_general);
            this.tabControl1.Controls.Add(this.tab_behavior);
            this.tabControl1.Controls.Add(this.tab_uploading);
            this.tabControl1.Controls.Add(this.tab_hotkeys);
            this.tabControl1.Controls.Add(this.tab_screens);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 211);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_general
            // 
            this.tab_general.Controls.Add(this.drop_save_quality);
            this.tab_general.Controls.Add(this.label_save_quality);
            this.tab_general.Controls.Add(this.drop_save_format);
            this.tab_general.Controls.Add(this.label_save_format);
            this.tab_general.Controls.Add(this.btn_browse_save_folder);
            this.tab_general.Controls.Add(this.txt_save_folder);
            this.tab_general.Controls.Add(this.check_save_screenshots);
            this.tab_general.Location = new System.Drawing.Point(4, 22);
            this.tab_general.Name = "tab_general";
            this.tab_general.Padding = new System.Windows.Forms.Padding(3);
            this.tab_general.Size = new System.Drawing.Size(344, 185);
            this.tab_general.TabIndex = 0;
            this.tab_general.Text = "General";
            this.tab_general.UseVisualStyleBackColor = true;
            // 
            // drop_save_quality
            // 
            this.drop_save_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_save_quality.Enabled = false;
            this.drop_save_quality.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drop_save_quality.FormattingEnabled = true;
            this.drop_save_quality.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10"});
            this.drop_save_quality.Location = new System.Drawing.Point(56, 88);
            this.drop_save_quality.Name = "drop_save_quality";
            this.drop_save_quality.Size = new System.Drawing.Size(121, 21);
            this.drop_save_quality.TabIndex = 6;
            // 
            // label_save_quality
            // 
            this.label_save_quality.Location = new System.Drawing.Point(8, 86);
            this.label_save_quality.Name = "label_save_quality";
            this.label_save_quality.Size = new System.Drawing.Size(42, 23);
            this.label_save_quality.TabIndex = 5;
            this.label_save_quality.Text = "Quality:";
            this.label_save_quality.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drop_save_format
            // 
            this.drop_save_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_save_format.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drop_save_format.FormattingEnabled = true;
            this.drop_save_format.Items.AddRange(new object[] {
            "bmp",
            "png",
            "jpg"});
            this.drop_save_format.Location = new System.Drawing.Point(56, 61);
            this.drop_save_format.Name = "drop_save_format";
            this.drop_save_format.Size = new System.Drawing.Size(121, 21);
            this.drop_save_format.TabIndex = 4;
            // 
            // label_save_format
            // 
            this.label_save_format.Location = new System.Drawing.Point(8, 59);
            this.label_save_format.Name = "label_save_format";
            this.label_save_format.Size = new System.Drawing.Size(42, 23);
            this.label_save_format.TabIndex = 3;
            this.label_save_format.Text = "Format:";
            this.label_save_format.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_browse_save_folder
            // 
            this.btn_browse_save_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse_save_folder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_browse_save_folder.Location = new System.Drawing.Point(261, 30);
            this.btn_browse_save_folder.Name = "btn_browse_save_folder";
            this.btn_browse_save_folder.Size = new System.Drawing.Size(75, 22);
            this.btn_browse_save_folder.TabIndex = 2;
            this.btn_browse_save_folder.Text = "browse";
            this.btn_browse_save_folder.UseVisualStyleBackColor = true;
            this.btn_browse_save_folder.Click += new System.EventHandler(this.Btn_browse_save_folderClick);
            // 
            // txt_save_folder
            // 
            this.txt_save_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_save_folder.Location = new System.Drawing.Point(8, 31);
            this.txt_save_folder.Name = "txt_save_folder";
            this.txt_save_folder.Size = new System.Drawing.Size(254, 20);
            this.txt_save_folder.TabIndex = 1;
            // 
            // check_save_screenshots
            // 
            this.check_save_screenshots.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check_save_screenshots.Location = new System.Drawing.Point(8, 6);
            this.check_save_screenshots.Name = "check_save_screenshots";
            this.check_save_screenshots.Size = new System.Drawing.Size(328, 19);
            this.check_save_screenshots.TabIndex = 0;
            this.check_save_screenshots.Text = "Save Screenshots Automatically";
            this.check_save_screenshots.UseVisualStyleBackColor = true;
            this.check_save_screenshots.CheckedChanged += new System.EventHandler(this.Check_save_screenshotsCheckedChanged);
            // 
            // tab_behavior
            // 
            this.tab_behavior.Controls.Add(this.check_show_cursor);
            this.tab_behavior.Controls.Add(this.check_edit_screenshot);
            this.tab_behavior.Controls.Add(this.check_launch_browser);
            this.tab_behavior.Controls.Add(this.check_balloon);
            this.tab_behavior.Controls.Add(this.check_sound_effects);
            this.tab_behavior.Controls.Add(this.check_copy_links);
            this.tab_behavior.Controls.Add(this.check_run_at_startup);
            this.tab_behavior.Location = new System.Drawing.Point(4, 22);
            this.tab_behavior.Name = "tab_behavior";
            this.tab_behavior.Padding = new System.Windows.Forms.Padding(3);
            this.tab_behavior.Size = new System.Drawing.Size(344, 185);
            this.tab_behavior.TabIndex = 1;
            this.tab_behavior.Text = "Behavior";
            this.tab_behavior.UseVisualStyleBackColor = true;
            // 
            // check_show_cursor
            // 
            this.check_show_cursor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check_show_cursor.Location = new System.Drawing.Point(8, 56);
            this.check_show_cursor.Name = "check_show_cursor";
            this.check_show_cursor.Size = new System.Drawing.Size(316, 19);
            this.check_show_cursor.TabIndex = 6;
            this.check_show_cursor.Text = "Show cursor in screenshots";
            this.check_show_cursor.UseVisualStyleBackColor = true;
            // 
            // check_edit_screenshot
            // 
            this.check_edit_screenshot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check_edit_screenshot.Location = new System.Drawing.Point(8, 156);
            this.check_edit_screenshot.Name = "check_edit_screenshot";
            this.check_edit_screenshot.Size = new System.Drawing.Size(316, 19);
            this.check_edit_screenshot.TabIndex = 5;
            this.check_edit_screenshot.Text = "Edit screenshot after capture";
            this.check_edit_screenshot.UseVisualStyleBackColor = true;
            // 
            // check_launch_browser
            // 
            this.check_launch_browser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check_launch_browser.Location = new System.Drawing.Point(8, 131);
            this.check_launch_browser.Name = "check_launch_browser";
            this.check_launch_browser.Size = new System.Drawing.Size(316, 19);
            this.check_launch_browser.TabIndex = 4;
            this.check_launch_browser.Text = "Launch browser after upload";
            this.check_launch_browser.UseVisualStyleBackColor = true;
            // 
            // check_balloon
            // 
            this.check_balloon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check_balloon.Location = new System.Drawing.Point(8, 106);
            this.check_balloon.Name = "check_balloon";
            this.check_balloon.Size = new System.Drawing.Size(316, 19);
            this.check_balloon.TabIndex = 3;
            this.check_balloon.Text = "Enable balloon messages";
            this.check_balloon.UseVisualStyleBackColor = true;
            // 
            // check_sound_effects
            // 
            this.check_sound_effects.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check_sound_effects.Location = new System.Drawing.Point(8, 81);
            this.check_sound_effects.Name = "check_sound_effects";
            this.check_sound_effects.Size = new System.Drawing.Size(316, 19);
            this.check_sound_effects.TabIndex = 2;
            this.check_sound_effects.Text = "Enable sound effects";
            this.check_sound_effects.UseVisualStyleBackColor = true;
            // 
            // check_copy_links
            // 
            this.check_copy_links.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check_copy_links.Location = new System.Drawing.Point(8, 31);
            this.check_copy_links.Name = "check_copy_links";
            this.check_copy_links.Size = new System.Drawing.Size(316, 19);
            this.check_copy_links.TabIndex = 1;
            this.check_copy_links.Text = "Copy links to clipboard";
            this.check_copy_links.UseVisualStyleBackColor = true;
            // 
            // check_run_at_startup
            // 
            this.check_run_at_startup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check_run_at_startup.Location = new System.Drawing.Point(8, 6);
            this.check_run_at_startup.Name = "check_run_at_startup";
            this.check_run_at_startup.Size = new System.Drawing.Size(316, 19);
            this.check_run_at_startup.TabIndex = 0;
            this.check_run_at_startup.Text = "Run at system startup";
            this.check_run_at_startup.UseVisualStyleBackColor = true;
            // 
            // tab_uploading
            // 
            this.tab_uploading.Controls.Add(this.drop_upload_method);
            this.tab_uploading.Controls.Add(this.label_upload_method);
            this.tab_uploading.Controls.Add(this.drop_upload_format);
            this.tab_uploading.Controls.Add(this.label_update_format);
            this.tab_uploading.Location = new System.Drawing.Point(4, 22);
            this.tab_uploading.Name = "tab_uploading";
            this.tab_uploading.Padding = new System.Windows.Forms.Padding(3);
            this.tab_uploading.Size = new System.Drawing.Size(344, 185);
            this.tab_uploading.TabIndex = 2;
            this.tab_uploading.Text = "Uploading";
            this.tab_uploading.UseVisualStyleBackColor = true;
            // 
            // drop_upload_method
            // 
            this.drop_upload_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_upload_method.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drop_upload_method.FormattingEnabled = true;
            this.drop_upload_method.Items.AddRange(new object[] {
            "do not upload",
            "imgur"});
            this.drop_upload_method.Location = new System.Drawing.Point(64, 6);
            this.drop_upload_method.Name = "drop_upload_method";
            this.drop_upload_method.Size = new System.Drawing.Size(121, 21);
            this.drop_upload_method.TabIndex = 8;
            // 
            // label_upload_method
            // 
            this.label_upload_method.Location = new System.Drawing.Point(8, 4);
            this.label_upload_method.Name = "label_upload_method";
            this.label_upload_method.Size = new System.Drawing.Size(50, 23);
            this.label_upload_method.TabIndex = 7;
            this.label_upload_method.Text = "Method:";
            this.label_upload_method.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drop_upload_format
            // 
            this.drop_upload_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_upload_format.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drop_upload_format.FormattingEnabled = true;
            this.drop_upload_format.Items.AddRange(new object[] {
            "bmp",
            "png",
            "jpg"});
            this.drop_upload_format.Location = new System.Drawing.Point(64, 33);
            this.drop_upload_format.Name = "drop_upload_format";
            this.drop_upload_format.Size = new System.Drawing.Size(121, 21);
            this.drop_upload_format.TabIndex = 6;
            // 
            // label_update_format
            // 
            this.label_update_format.Location = new System.Drawing.Point(8, 31);
            this.label_update_format.Name = "label_update_format";
            this.label_update_format.Size = new System.Drawing.Size(50, 23);
            this.label_update_format.TabIndex = 5;
            this.label_update_format.Text = "Format:";
            this.label_update_format.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_hotkeys
            // 
            this.tab_hotkeys.Controls.Add(this.txt_hotkey_window);
            this.tab_hotkeys.Controls.Add(this.label_window_screenshot);
            this.tab_hotkeys.Controls.Add(this.txt_hotkey_region);
            this.tab_hotkeys.Controls.Add(this.label_region_screenshot);
            this.tab_hotkeys.Controls.Add(this.txt_hotkey_screenshot);
            this.tab_hotkeys.Controls.Add(this.label_screenshot);
            this.tab_hotkeys.Controls.Add(this.label_hotkeys_instructions);
            this.tab_hotkeys.Location = new System.Drawing.Point(4, 22);
            this.tab_hotkeys.Name = "tab_hotkeys";
            this.tab_hotkeys.Padding = new System.Windows.Forms.Padding(3);
            this.tab_hotkeys.Size = new System.Drawing.Size(344, 185);
            this.tab_hotkeys.TabIndex = 3;
            this.tab_hotkeys.Text = "Hotkeys";
            this.tab_hotkeys.UseVisualStyleBackColor = true;
            // 
            // txt_hotkey_window
            // 
            this.txt_hotkey_window.Location = new System.Drawing.Point(187, 92);
            this.txt_hotkey_window.Name = "txt_hotkey_window";
            this.txt_hotkey_window.ReadOnly = true;
            this.txt_hotkey_window.Size = new System.Drawing.Size(108, 20);
            this.txt_hotkey_window.TabIndex = 15;
            this.txt_hotkey_window.Text = "Ctrl + Shift + 5";
            this.txt_hotkey_window.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hotkey_KeyDown);
            // 
            // label_window_screenshot
            // 
            this.label_window_screenshot.Location = new System.Drawing.Point(41, 90);
            this.label_window_screenshot.Name = "label_window_screenshot";
            this.label_window_screenshot.Size = new System.Drawing.Size(140, 23);
            this.label_window_screenshot.TabIndex = 14;
            this.label_window_screenshot.Text = "3. Take window screenshot";
            this.label_window_screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_hotkey_region
            // 
            this.txt_hotkey_region.Location = new System.Drawing.Point(187, 62);
            this.txt_hotkey_region.Name = "txt_hotkey_region";
            this.txt_hotkey_region.ReadOnly = true;
            this.txt_hotkey_region.Size = new System.Drawing.Size(108, 20);
            this.txt_hotkey_region.TabIndex = 10;
            this.txt_hotkey_region.Text = "Ctrl + Shift + 4";
            this.txt_hotkey_region.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hotkey_KeyDown);
            // 
            // label_region_screenshot
            // 
            this.label_region_screenshot.Location = new System.Drawing.Point(41, 60);
            this.label_region_screenshot.Name = "label_region_screenshot";
            this.label_region_screenshot.Size = new System.Drawing.Size(140, 23);
            this.label_region_screenshot.TabIndex = 9;
            this.label_region_screenshot.Text = "2. Take region screenshot:";
            this.label_region_screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_hotkey_screenshot
            // 
            this.txt_hotkey_screenshot.Location = new System.Drawing.Point(187, 32);
            this.txt_hotkey_screenshot.Name = "txt_hotkey_screenshot";
            this.txt_hotkey_screenshot.ReadOnly = true;
            this.txt_hotkey_screenshot.Size = new System.Drawing.Size(108, 20);
            this.txt_hotkey_screenshot.TabIndex = 5;
            this.txt_hotkey_screenshot.Text = "Ctrl+ Shift + 3";
            this.txt_hotkey_screenshot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hotkey_KeyDown);
            // 
            // label_screenshot
            // 
            this.label_screenshot.Location = new System.Drawing.Point(41, 30);
            this.label_screenshot.Name = "label_screenshot";
            this.label_screenshot.Size = new System.Drawing.Size(140, 23);
            this.label_screenshot.TabIndex = 4;
            this.label_screenshot.Text = "1. Take screenshot:";
            this.label_screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_hotkeys_instructions
            // 
            this.label_hotkeys_instructions.Location = new System.Drawing.Point(8, 6);
            this.label_hotkeys_instructions.Name = "label_hotkeys_instructions";
            this.label_hotkeys_instructions.Size = new System.Drawing.Size(322, 23);
            this.label_hotkeys_instructions.TabIndex = 0;
            this.label_hotkeys_instructions.Text = "Set your own hotkeys here.";
            this.label_hotkeys_instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_screens
            // 
            this.tab_screens.Controls.Add(this.btn_reset_screen);
            this.tab_screens.Controls.Add(this.numeric_height);
            this.tab_screens.Controls.Add(this.numeric_width);
            this.tab_screens.Controls.Add(this.numeric_left);
            this.tab_screens.Controls.Add(this.label3);
            this.tab_screens.Controls.Add(this.label2);
            this.tab_screens.Controls.Add(this.label_screen_y);
            this.tab_screens.Controls.Add(this.numeric_top);
            this.tab_screens.Controls.Add(this.label_screen_x);
            this.tab_screens.Location = new System.Drawing.Point(4, 22);
            this.tab_screens.Name = "tab_screens";
            this.tab_screens.Padding = new System.Windows.Forms.Padding(3);
            this.tab_screens.Size = new System.Drawing.Size(344, 185);
            this.tab_screens.TabIndex = 4;
            this.tab_screens.Text = "Screen";
            this.tab_screens.UseVisualStyleBackColor = true;
            // 
            // btn_reset_screen
            // 
            this.btn_reset_screen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_reset_screen.Location = new System.Drawing.Point(51, 90);
            this.btn_reset_screen.Name = "btn_reset_screen";
            this.btn_reset_screen.Size = new System.Drawing.Size(120, 23);
            this.btn_reset_screen.TabIndex = 10;
            this.btn_reset_screen.Text = "Reset";
            this.btn_reset_screen.UseVisualStyleBackColor = true;
            this.btn_reset_screen.Click += new System.EventHandler(this.Btn_reset_screenClick);
            // 
            // numeric_height
            // 
            this.numeric_height.Location = new System.Drawing.Point(51, 70);
            this.numeric_height.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numeric_height.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numeric_height.Name = "numeric_height";
            this.numeric_height.Size = new System.Drawing.Size(120, 20);
            this.numeric_height.TabIndex = 9;
            this.numeric_height.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // numeric_width
            // 
            this.numeric_width.Location = new System.Drawing.Point(51, 49);
            this.numeric_width.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numeric_width.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numeric_width.Name = "numeric_width";
            this.numeric_width.Size = new System.Drawing.Size(120, 20);
            this.numeric_width.TabIndex = 8;
            this.numeric_width.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // numeric_left
            // 
            this.numeric_left.Location = new System.Drawing.Point(51, 7);
            this.numeric_left.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numeric_left.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numeric_left.Name = "numeric_left";
            this.numeric_left.Size = new System.Drawing.Size(120, 20);
            this.numeric_left.TabIndex = 7;
            this.numeric_left.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_screen_y
            // 
            this.label_screen_y.Location = new System.Drawing.Point(6, 7);
            this.label_screen_y.Name = "label_screen_y";
            this.label_screen_y.Size = new System.Drawing.Size(45, 17);
            this.label_screen_y.TabIndex = 4;
            this.label_screen_y.Text = "Left:";
            this.label_screen_y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numeric_top
            // 
            this.numeric_top.Location = new System.Drawing.Point(51, 28);
            this.numeric_top.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numeric_top.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numeric_top.Name = "numeric_top";
            this.numeric_top.Size = new System.Drawing.Size(120, 20);
            this.numeric_top.TabIndex = 3;
            this.numeric_top.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // label_screen_x
            // 
            this.label_screen_x.Location = new System.Drawing.Point(6, 28);
            this.label_screen_x.Name = "label_screen_x";
            this.label_screen_x.Size = new System.Drawing.Size(45, 17);
            this.label_screen_x.TabIndex = 2;
            this.label_screen_x.Text = "Top:";
            this.label_screen_x.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_save.Location = new System.Drawing.Point(191, 213);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Okay";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_saveClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancel.Location = new System.Drawing.Point(273, 213);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancelClick);
            // 
            // frm_Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 240);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Frm_PreferencesLoad);
            this.tabControl1.ResumeLayout(false);
            this.tab_general.ResumeLayout(false);
            this.tab_general.PerformLayout();
            this.tab_behavior.ResumeLayout(false);
            this.tab_uploading.ResumeLayout(false);
            this.tab_hotkeys.ResumeLayout(false);
            this.tab_hotkeys.PerformLayout();
            this.tab_screens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_top)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btn_reset_screen;
		private System.Windows.Forms.NumericUpDown numeric_height;
		private System.Windows.Forms.NumericUpDown numeric_width;
		private System.Windows.Forms.NumericUpDown numeric_left;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_screen_y;
		private System.Windows.Forms.NumericUpDown numeric_top;
		private System.Windows.Forms.Label label_screen_x;
		private System.Windows.Forms.TabPage tab_screens;
		private System.Windows.Forms.ComboBox drop_upload_method;
		private System.Windows.Forms.Label label_upload_method;
		private System.Windows.Forms.ComboBox drop_upload_format;
		private System.Windows.Forms.Label label_update_format;
		private System.Windows.Forms.CheckBox check_show_cursor;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.TextBox txt_hotkey_window;
		private System.Windows.Forms.Label label_window_screenshot;
		private System.Windows.Forms.TextBox txt_hotkey_region;
		private System.Windows.Forms.Label label_region_screenshot;
		private System.Windows.Forms.TextBox txt_hotkey_screenshot;
		private System.Windows.Forms.Label label_screenshot;
		private System.Windows.Forms.Label label_hotkeys_instructions;
		private System.Windows.Forms.CheckBox check_edit_screenshot;
		private System.Windows.Forms.CheckBox check_launch_browser;
		private System.Windows.Forms.CheckBox check_balloon;
		private System.Windows.Forms.CheckBox check_sound_effects;
		private System.Windows.Forms.CheckBox check_copy_links;
		private System.Windows.Forms.CheckBox check_run_at_startup;
		private System.Windows.Forms.ComboBox drop_save_quality;
		private System.Windows.Forms.Label label_save_quality;
		private System.Windows.Forms.ComboBox drop_save_format;
		private System.Windows.Forms.Label label_save_format;
		private System.Windows.Forms.Button btn_browse_save_folder;
		private System.Windows.Forms.TextBox txt_save_folder;
		private System.Windows.Forms.CheckBox check_save_screenshots;
		private System.Windows.Forms.TabPage tab_hotkeys;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tab_general;
		private System.Windows.Forms.TabPage tab_behavior;
		private System.Windows.Forms.TabPage tab_uploading;
	}
}
