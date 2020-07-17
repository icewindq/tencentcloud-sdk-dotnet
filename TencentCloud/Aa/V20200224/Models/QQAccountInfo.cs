/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Aa.V20200224.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QQAccountInfo : AbstractModel
    {
        
        /// <summary>
        /// QQ的OpenID。
        /// </summary>
        [JsonProperty("QQOpenId")]
        public string QQOpenId{ get; set; }

        /// <summary>
        /// QQ分配给网站或应用的AppId，用来唯一标识网站或应用。
        /// </summary>
        [JsonProperty("AppIdUser")]
        public string AppIdUser{ get; set; }

        /// <summary>
        /// 用于标识QQ用户登录后所关联业务自身的账号ID。
        /// </summary>
        [JsonProperty("AssociateAccount")]
        public string AssociateAccount{ get; set; }

        /// <summary>
        /// 账号绑定的手机号。
        /// </summary>
        [JsonProperty("MobilePhone")]
        public string MobilePhone{ get; set; }

        /// <summary>
        /// 用户设备号。
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QQOpenId", this.QQOpenId);
            this.SetParamSimple(map, prefix + "AppIdUser", this.AppIdUser);
            this.SetParamSimple(map, prefix + "AssociateAccount", this.AssociateAccount);
            this.SetParamSimple(map, prefix + "MobilePhone", this.MobilePhone);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
        }
    }
}

