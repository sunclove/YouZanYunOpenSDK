﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Constant
{
    public class API
    {

        /// <summary>
        /// API请求域名
        /// </summary>
        internal const string GATEWAY = "https://open.youzanyun.com";

        #region METHOD

        /// <summary>
        /// GET
        /// </summary>
        public const string METHOD_GET = "get";
        /// <summary>
        /// POST
        /// </summary>
        public const string METHOD_POST = "post";

        #endregion

        #region API版本

        /// <summary>
        /// 版本号：1.0.0
        /// </summary>
        public const string VERSION_1_0_0 = "1.0.0";

        /// <summary>
        /// 版本号：3.0.0
        /// </summary>
        public const string VERSION_3_0_0 = "3.0.0";

        /// <summary>
        /// 版本号：3.0.1
        /// </summary>
        public const string VERSION_3_0_1 = "3.0.1";

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
        /// 获取分销员账户信息，不支持返回分销员等级
        /// </summary>
        internal const string SALESMAN_ACCOUNT_GET = "youzan.salesman.account.get";
        /// <summary>
        /// 设置用户成为分销员
        /// </summary>
        internal const string SALESMAN_ACCOUNT_ADD = "youzan.salesman.account.add";
        /// <summary>
        /// 更新分销员信息,客户已经是分销员才可以更新
        /// </summary>
        internal const string SALESMAN_ACCOUNT_UPDATE = "youzan.salesman.account.update";
        /// <summary>
        /// 清退分销员，客户必须是分销员才能清退
        /// </summary>
        internal const string SALESMAN_ACCOUNT_FIRE = "youzan.salesman.account.fire";
        /// <summary>
        /// 获取推广订单列表
        /// </summary>
        internal const string SALESMAN_TRADES_GET = "youzan.salesman.trades.get";
        /// <summary>
        /// 获取商品推广链接
        /// </summary>
        internal const string SALESMAN_ITEM_SHARE_GET = "youzan.salesman.item.share.get";
        /// <summary>
        /// 获取分销员业绩统计
        /// </summary>
        internal const string SALESMAN_ACCOUNT_SCORE_SEARCH = "youzan.salesman.account.score.search";
        /// <summary>
        /// 批量获取商品提成比例信息
        /// </summary>
        internal const string SALESMAN_ITEMS_GET = "youzan.salesman.items.get";

        #endregion

        #region 优惠券/码API

        /// <summary>
        /// 发放优惠券优惠码
        /// </summary>
        internal const string UMP_COUPON_TAKE = "youzan.ump.coupon.take";

        #endregion

        #region 商品API

        /// <summary>
        /// 获取出售中的商品列表，可获取微商城全部商品信息
        /// </summary>
        internal const string ITEMS_ONSALE_GET = "youzan.items.onsale.get";

        #endregion

        #endregion
    }
}