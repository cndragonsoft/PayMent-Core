using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpOrderRatingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpOrderRatingQueryModel : AlipayObject
    {
        /// <summary>
        /// 芝麻企业信用评估订单号
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
