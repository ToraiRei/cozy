﻿using CozyAnywhere.Plugin.WinMouse.Args;
using CozyAnywhere.Protocol;
using Newtonsoft.Json;

namespace CozyAnywhere.Plugin.WinMouse.ArgsFactory
{
    public class MouseSetCursorPositionArgsFactory : IPluginCommandMethodArgsFactory
    {
        public PluginCommandMethodArgs Create(string argsContent)
        {
            return JsonConvert.DeserializeObject<MouseSetCursorPositionArgs>(argsContent);
        }
    }
}