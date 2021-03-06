﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyAdventure.Game.Model
{
    public class Follower
    {
        public int Id { get; set; }

        // 名字
        public string Name { get; set; }

        // 描述
        public string Desc { get; set; }

        // 基础战力
        public int BasicAttack { get; set; } = 1;

        // 成长细数
        public float GrowRatio { get; set; } = 1.0f;

        // 星级
        public int MaxStar { get; set; } = 0;
        public int CurStar { get; set; } = 0;

        // 等级
        public int CurLevel { get; set; } = 0;

        // 阶层
        public int CurRank { get; set; } = 0;
    }
}
