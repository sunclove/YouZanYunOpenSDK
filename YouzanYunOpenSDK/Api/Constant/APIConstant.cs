﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Constant
{
    internal class API
    {

        /// <summary>
        /// API请求域名
        /// </summary>
        internal const string GATEWAY = "https://open.youzanyun.com";

        #region METHOD

        /// <summary>
        /// GET
        /// </summary>
        internal const string METHOD_GET = "get";
        /// <summary>
        /// POST
        /// </summary>
        internal const string METHOD_POST = "post";

        #endregion

        #region API版本

        /// <summary>
        /// 版本号：1.0.0
        /// </summary>
        internal const string VERSION_1_0_0 = "1.0.0";

        /// <summary>
        /// 版本号：3.0.0
        /// </summary>
        internal const string VERSION_3_0_0 = "3.0.0";

        /// <summary>
        /// 版本号：3.0.1
        /// </summary>
        internal const string VERSION_3_0_1 = "3.0.1";

        #endregion

        #region API列表

        #region 用户API

        /// <summary>
        /// 查询是否存在有赞帐号
        /// </summary>
        internal const string USERS_ACCOUNT_CHECK = "youzan.users.account.check";

        #endregion

        #region 客户API

        /// <summary>
        /// 创建客户
        /// 手机号和{"name":"丽丽"}必填
        /// </summary>
        internal const string SCRM_CUSTOMER_CREATE = "youzan.scrm.customer.create";

        #endregion

        #region 分销员API

        /// <summary>
        /// 设置用户成为分销员
        /// </summary>
        internal const string SALESMAN_ACCOUNT_ADD = "youzan.salesman.account.add";
        /// <summary>
        /// 更新分销员信息,客户已经是分销员才可以更新
        /// </summary>
        internal const string SALESMAN_ACCOUNT_UPDATE = "youzan.salesman.account.update";

        #endregion

        #endregion
    }
}