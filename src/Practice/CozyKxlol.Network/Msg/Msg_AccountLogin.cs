﻿using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyKxlol.Network.Msg
{
    public class Msg_AccountLogin : MsgBase
    {
        public Msg_AccountLogin() : base(MsgId.AccountLogin) { }

        public String name { get; set; }
        public String pass { get; set; }

        public override void W(NetOutgoingMessage om)
        {
            base.W(om);
            om.Write(name);
            om.Write(pass);
        }

        public override void R(NetIncomingMessage im)
        {
            base.R(im);
            name = im.ReadString();
            pass = im.ReadString();
        }
    }
}