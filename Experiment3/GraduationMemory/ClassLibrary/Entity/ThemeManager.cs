using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    // 主题工厂，用于创建不同类型的消息主题
    public class SimpleThemeFactory
    {
        // 创建特定名称的消息主题
        public MessageTheme CreateTheme(string themeName)
        {
            MessageTheme theme = null;
            // 根据主题名称选择相应的主题类型
            switch (themeName)
            {
                case "GraduationMessage":
                    theme = new GraduationMessage(); // 创建毕业主题
                    break;
                case "MemoryMap":
                    theme = new MemoryMap(); // 创建记忆地图主题
                    break;
                    // 可以继续添加其他主题类型的支持
                    // case "AnotherTheme":
                    //    theme = new AnotherTheme();
                    //    break;
            }
            return theme; // 返回创建的消息主题
        }
    }

    // 主题管理器，用于管理消息主题
    public class ThemeManager
    {
        private SimpleThemeFactory _factory; // 主题工厂实例

        // 构造函数，接受一个主题工厂实例作为参数
        public ThemeManager(SimpleThemeFactory factory)
        {
            _factory = factory; // 初始化主题工厂
        }

        // 创建特定名称的消息主题
        public MessageTheme MakeTheme(string themeName)
        {
            var theme = _factory.CreateTheme(themeName); // 使用工厂创建消息主题
            return theme; // 返回创建的消息主题
        }
    }
}
