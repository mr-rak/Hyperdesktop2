using System;
using System.Windows.Forms;

namespace hyperdesktop2
{
	public partial class frm_Preferences : Form
	{
		
		public frm_Preferences()
		{
			InitializeComponent();
		}
		
		void Frm_PreferencesLoad(object sender, EventArgs e)
		{
			check_save_screenshots.Checked 		= Settings.save_screenshots;
			txt_save_folder.Text 				= Settings.save_folder;
			drop_save_format.Text 				= Settings.save_format;
			drop_save_quality.Text 				= Settings.save_quality.ToString();
			
			drop_upload_method.Text 			= Settings.upload_method;
			drop_upload_format.Text 			= Settings.upload_format;

            txt_api_key.Text                    = Settings.api_key;
			
			check_run_at_startup.Checked 		= Global_Func.reg_key.GetValue("Hyperdesktop2") != null;
			check_copy_links.Checked 			= Settings.copy_links_to_clipboard;
			check_sound_effects.Checked			= Settings.sound_effects;
			check_show_cursor.Checked			= Settings.show_cursor;
			check_balloon.Checked 				= Settings.balloon_messages;
			check_launch_browser.Checked 		= Settings.launch_browser;
			check_edit_screenshot.Checked 		= Settings.edit_screenshot;
		
			numeric_top.Minimum = -50000;
			numeric_left.Minimum = -50000;
			numeric_width.Minimum = -50000;
			numeric_height.Minimum = -50000;
			
			try {
                String[] screen_res = Settings.screen_res.Split(',');
				numeric_left.Value = Convert.ToDecimal(screen_res[0]);
				numeric_top.Value = Convert.ToDecimal(screen_res[1]);
				numeric_width.Value = Convert.ToDecimal(screen_res[2]);
				numeric_height.Value = Convert.ToDecimal(screen_res[3]);
			} catch {
				btn_reset_screen.PerformClick();
			}

            SetKeyName(txt_hotkey_screenshot, Settings.hotkey_screenshot.Item1, Settings.hotkey_screenshot.Item2);
            SetKeyName(txt_hotkey_region, Settings.hotkey_region.Item1, Settings.hotkey_region.Item2);
            SetKeyName(txt_hotkey_window, Settings.hotkey_window.Item1, Settings.hotkey_window.Item2);
        }

        void SetKeyName(TextBox obj, ModifierKeys mod, Keys key)
        {
            String text = String.Empty;
            if (key == Keys.Escape)
            {
                obj.Text = "None";
                obj.Tag = new Tuple<ModifierKeys, Keys>(0, 0);
                return;
            }

            if (mod.HasFlag(global::ModifierKeys.Control))
                text += "Ctrl + ";
            if (mod.HasFlag(global::ModifierKeys.Alt))
                text += "Alt + ";
            if (mod.HasFlag(global::ModifierKeys.Shift))
                text += "Shift + ";
            if (key != Keys.ControlKey && key != Keys.Menu && key != Keys.ShiftKey)
                text += (new KeysConverter()).ConvertToString(key);

            obj.Text = text;
            obj.Tag = new Tuple<ModifierKeys, Keys>(mod, key);
        }
		
		#region Save & Cancel
		void Btn_saveClick(object sender, EventArgs e)
		{
			// Screen resolution
			Settings.screen_res 				= Settings.screen_res = String.Format(
				"{0},{1},{2},{3}",
				numeric_left.Value,
				numeric_top.Value,
				numeric_width.Value,
				numeric_height.Value
			);

            Screen_Bounds.load();
			
			Settings.save_screenshots 			= check_save_screenshots.Checked;
			Settings.save_folder 				= txt_save_folder.Text;
			Settings.save_format 				= drop_save_format.Text;
			Settings.save_quality 				= Convert.ToInt16(drop_save_quality.Text);
			
			Settings.upload_method 				= drop_upload_method.Text;
			Settings.upload_format 				= drop_upload_format.Text;
            Settings.api_key                    = txt_api_key.Text;
			
			Settings.copy_links_to_clipboard 	= check_copy_links.Checked;
			Settings.sound_effects 				= check_sound_effects.Checked;
			Settings.show_cursor 				= check_show_cursor.Checked;
			Settings.balloon_messages 			= check_balloon.Checked;
			Settings.launch_browser 			= check_launch_browser.Checked;
			Settings.edit_screenshot 			= check_edit_screenshot.Checked;

            Settings.hotkey_screenshot          = (Tuple<ModifierKeys, Keys>)txt_hotkey_screenshot.Tag;
            Settings.hotkey_region              = (Tuple<ModifierKeys, Keys>)txt_hotkey_region.Tag;
            Settings.hotkey_window              = (Tuple<ModifierKeys, Keys>)txt_hotkey_window.Tag;

            Settings.write_settings();
			Global_Func.run_at_startup(check_run_at_startup.Checked);
            
            Dispose();
		}
		void Btn_cancelClick(object sender, EventArgs e)
		{
			Dispose();
		}
		#endregion
		
		#region General
		void Check_save_screenshotsCheckedChanged(object sender, EventArgs e)
		{
			txt_save_folder.Enabled 		= check_save_screenshots.Checked;
			btn_browse_save_folder.Enabled 	= check_save_screenshots.Checked;
			drop_save_format.Enabled 		= check_save_screenshots.Checked;
			drop_save_quality.Enabled 		= check_save_screenshots.Checked;
		}
		void Btn_browse_save_folderClick(object sender, EventArgs e)
		{
			var browse_folder = new FolderBrowserDialog();
			if (browse_folder.ShowDialog() == DialogResult.OK)
			    txt_save_folder.Text = browse_folder.SelectedPath;
		}
		void Btn_reset_screenClick(object sender, System.EventArgs e)
		{
            String[] screen_res = Screen_Bounds.reset().Split(',');
            numeric_left.Value = Convert.ToDecimal(screen_res[0]);
			numeric_top.Value = Convert.ToDecimal(screen_res[1]);
			numeric_width.Value = Convert.ToDecimal(screen_res[2]);
			numeric_height.Value = Convert.ToDecimal(screen_res[3]);
		}
        #endregion

        private void Hotkey_KeyDown(object sender, KeyEventArgs e)
        {
            ModifierKeys mod = 0;
            mod = (e.Control ? global::ModifierKeys.Control : 0) | (e.Alt ? global::ModifierKeys.Alt : 0) | (e.Shift ? global::ModifierKeys.Shift : 0);
            SetKeyName((TextBox)sender, mod, e.KeyCode);
        }
    }
}
