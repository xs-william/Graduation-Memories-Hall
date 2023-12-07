using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using MainForm;

namespace Forms
{
    public partial class ThemeForm : UIForm
    {
        public static ThemeService themeService
        {
            get
            {
                return ThemeService.GetInstance;
            }
        }
        public string ThemeName { get; set; }
        User user;

        public ThemeForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public void ThemeCreator(string themeName)
        {
            if (themeService.GetTheme(themeName) == null)
            {
                var ThemeStore = new ThemeManager(new SimpleThemeFactory());
                var graduation_message = ThemeStore.MakeTheme(themeName);
                themeService.AddTheme(graduation_message);
            }
        }

        private void GraduationMessage_Click(object sender, EventArgs e)
        {
            MessageForm messageForm = new MessageForm(user);
            ThemeName = "GraduationMessage";
            ThemeCreator(ThemeName);

            messageForm.ShowDialog();
        }

        private void MemoryMap_Click(object sender, EventArgs e)
        {
            MessageForm messageForm = new MessageForm(user);
            ThemeName = "MemoryMap";
            //简单工厂创建主题
            /*var ThemeStore = new ThemeManager(new SimpleThemeFactory());
            var graduation_message = ThemeStore.MakeTheme("GraduationMessage");
            themeService.AddTheme(graduation_message);*/
            ThemeCreator(ThemeName);

            messageForm.ShowDialog();

        }
    }
}
