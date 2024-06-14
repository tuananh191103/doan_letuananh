using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.MoMo_API
{
    public class momoInfo
    {
        /*
        public static readonly string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
        public static readonly string partnerCode = "MOMOOGKO20210828";
        public static readonly string accessKey = "XAHgqwYkP9MpFtAR";
        public static readonly string serectkey = "DYCxTKskptCiDL4SGI7TQOMPr7DEo2RH";
        public static readonly string orderInfo = "Hiệu sách Đông Triều";
        public static readonly string returnUrl = "https://localhost:44350/confirm-orderPaymentOnlineMomo";
        public static readonly string notifyurl = "https://localhost:44350/cancel-orderMomo";*/

        
        public static readonly string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
        public static readonly string partnerCode = "MOMOOGKO20210828";
        public static readonly string accessKey = "XAHgqwYkP9MpFtAR";
        public static readonly string serectkey = "DYCxTKskptCiDL4SGI7TQOMPr7DEo2RH";
        public static readonly string orderInfo = "Hiệu sách Đông Triều";
        public static readonly string returnUrl = "http://222.255.46.4:3000/confirm-orderPaymentOnlineMomo";
        public static readonly string notifyurl = "http://222.255.46.4:3000/cancel-orderMomo";
    }
}