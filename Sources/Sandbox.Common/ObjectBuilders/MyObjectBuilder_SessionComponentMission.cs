﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRage.Serialization;

namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    public class MyObjectBuilder_SessionComponentMission
    {
        [Serializable]
        public struct pair
        {
            public ulong stm;
            public int ser;
            public pair(ulong p1, int p2)
            {
                this.stm = p1;
                this.ser = p2;
            }
        }

        [ProtoMember(1)]
        public SerializableDictionary<pair, MyObjectBuilder_MissionTriggers> Triggers = new SerializableDictionary<pair, MyObjectBuilder_MissionTriggers>();

    }
}
