/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UpdateWebsiteInstanceRequest : RpcAcsRequest<UpdateWebsiteInstanceResponse>
    {
        public UpdateWebsiteInstanceRequest()
            : base("Green", "2017-08-23", "UpdateWebsiteInstance", "green", "openAPI")
        {
        }

		private string siteProtocol;

		private string instanceId;

		private string sourceIp;

		private int? websiteScanInterval;

		private string domain;

		private string indexPage;

		private string lang;

		private int? indexPageScanInterval;

		public string SiteProtocol
		{
			get
			{
				return siteProtocol;
			}
			set	
			{
				siteProtocol = value;
				DictionaryUtil.Add(QueryParameters, "SiteProtocol", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public int? WebsiteScanInterval
		{
			get
			{
				return websiteScanInterval;
			}
			set	
			{
				websiteScanInterval = value;
				DictionaryUtil.Add(QueryParameters, "WebsiteScanInterval", value.ToString());
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		public string IndexPage
		{
			get
			{
				return indexPage;
			}
			set	
			{
				indexPage = value;
				DictionaryUtil.Add(QueryParameters, "IndexPage", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public int? IndexPageScanInterval
		{
			get
			{
				return indexPageScanInterval;
			}
			set	
			{
				indexPageScanInterval = value;
				DictionaryUtil.Add(QueryParameters, "IndexPageScanInterval", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateWebsiteInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateWebsiteInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
