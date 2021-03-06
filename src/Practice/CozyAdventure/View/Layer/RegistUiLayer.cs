﻿using CocosSharp;
using CozyAdventure.Public.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyAdventure.View.Layer
{
    public class RegistUiLayer : CCLayer
    {
        public RegistUiLayer()
        {
            var title = new CCLabel("冒险与编程", "Consolas", 72)
            {
                Position    = new CCPoint(400, 320),
                Color       = CCColor3B.Yellow
            };
            AddChild(title, 100);

            var begin = new CozySampleButton(300, 100, 200, 80)
            {
                Text        = "开始游戏",
                FontSize    = 24
            };
            AddChild(begin, 100);
        }
    }
}
