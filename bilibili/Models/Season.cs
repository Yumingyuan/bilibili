﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilibili.Models
{
    class Episodes
    {
       /// <summary>
       /// 视频ID（av_id）
       /// </summary>
        public string ID { get; set; }
       /// <summary>
       /// 硬币
       /// </summary>
        public string Coins { get; set; }
       /// <summary>
       /// 弹幕
       /// </summary>
        public string Danmaku { get; set; }
       /// <summary>
       /// 封面
       /// </summary>
        public string Cover { get; set; }
       /// <summary>
       /// 索引
       /// </summary>
        public string Index { get; set; }
       /// <summary>
       /// 标题
       /// </summary>
        public string Title { get; set; }
       /// <summary>
       /// 时间
       /// </summary>
        public string Time { get; set; }
    }
    class Season
    {
        public string IsConcerned { get; set; }
        public string Coins { get; set; }
        public string Danmaku { get; set; }
        public string Copyright { get; set; }
        public string Cover { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public List<string> Tags { get; set; }
        public string WeekDay { get; set; }
        public string Time { get; set; }
        public string View { get; set; }
        public bool isFinish { get; set; }
        public string Fav { get; set; }
        public string Staff { get; set; }
        public string SquareCover { get; set;}
        public List<Cast> CVlist { get; set;}
        public List<Episodes> EPS { get; set; }
        public List<RelateSeason> Related { get; set; }
    }
    class RelateSeason
    {
        public string Title { get; set; }
        public string Sid { get; set; }
    }
    class Cast
    {
        public string Actor { get; set; }
        public string Role { get; set; }
    }
    class LastUpdate
    {
        private string _index;
        private string _watch;
        public string Cover { get; set; }
        public string Index
        {
            get { return "更新到第" + _index + "话"; }
            set { _index = value; }
        }
        public string Title { get; set; }
        public string Watch
        {
            get { return _watch + "人在看"; }
            set { _watch = value; }
        }
        public string Sid { get; set; }
        public string Time { get; set; }
    }
}
