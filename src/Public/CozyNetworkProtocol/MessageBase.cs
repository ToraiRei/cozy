﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lidgren.Network;

namespace CozyNetworkProtocol
{
    public abstract class MessageBase
    {
        public abstract uint Id { get; }

        public virtual void Read(NetBuffer im)
        {
            im.Position = 0;
            im.ReadAllProperties(this);
        }

        public virtual void Write(NetBuffer om)
        {
            om.Position = 0;
            om.WriteAllProperties(this);
        }
    }
}
