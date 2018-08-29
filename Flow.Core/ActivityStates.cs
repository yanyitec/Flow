using System;
using System.Collections.Generic;
using System.Text;

namespace Flow
{
    [Flags]
    public enum ActivityStates
    {
        NoActions=-1,
        /// <summary>
        /// 已创建，
        /// </summary>
        Creating = 0,
        /// <summary>
        /// 把entity存储到了数据库中
        /// </summary>
        Created = 1<<1,//1
        //Inited = 1 << 2,//2
        /// <summary>
        /// 正在处理中，处理未完成，下次还会调用execute
        /// </summary>
        Executing = 1 << 3, //4
        /// <summary>
        /// 已经处理完成，等待结束检查
        /// </summary>
        Executed = 1 << 4, //4

        Fullfilled = 1 << 5,//8
        //Rejected = 1 << 6, //16
        Canceled = 1 << 7, //32
        Error = 1 << 8, //64
        Completed = Fullfilled | Canceled | Error
    }
}
