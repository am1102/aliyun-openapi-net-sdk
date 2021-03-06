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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class UploadServerCertificateResponse : AcsResponse
	{

		private string requestId;

		private string serverCertificateId;

		private string fingerprint;

		private string serverCertificateName;

		private string regionId;

		private string regionIdAlias;

		private string aliCloudCertificateId;

		private string aliCloudCertificateName;

		private int? isAliCloudCertificate;

		private string resourceGroupId;

		private string createTime;

		private long? createTimeStamp;

		private string expireTime;

		private long? expireTimeStamp;

		private string commonName;

		private List<string> subjectAlternativeNames;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string ServerCertificateId
		{
			get
			{
				return serverCertificateId;
			}
			set	
			{
				serverCertificateId = value;
			}
		}

		public string Fingerprint
		{
			get
			{
				return fingerprint;
			}
			set	
			{
				fingerprint = value;
			}
		}

		public string ServerCertificateName
		{
			get
			{
				return serverCertificateName;
			}
			set	
			{
				serverCertificateName = value;
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		public string RegionIdAlias
		{
			get
			{
				return regionIdAlias;
			}
			set	
			{
				regionIdAlias = value;
			}
		}

		public string AliCloudCertificateId
		{
			get
			{
				return aliCloudCertificateId;
			}
			set	
			{
				aliCloudCertificateId = value;
			}
		}

		public string AliCloudCertificateName
		{
			get
			{
				return aliCloudCertificateName;
			}
			set	
			{
				aliCloudCertificateName = value;
			}
		}

		public int? IsAliCloudCertificate
		{
			get
			{
				return isAliCloudCertificate;
			}
			set	
			{
				isAliCloudCertificate = value;
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public long? CreateTimeStamp
		{
			get
			{
				return createTimeStamp;
			}
			set	
			{
				createTimeStamp = value;
			}
		}

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
			}
		}

		public long? ExpireTimeStamp
		{
			get
			{
				return expireTimeStamp;
			}
			set	
			{
				expireTimeStamp = value;
			}
		}

		public string CommonName
		{
			get
			{
				return commonName;
			}
			set	
			{
				commonName = value;
			}
		}

		public List<string> SubjectAlternativeNames
		{
			get
			{
				return subjectAlternativeNames;
			}
			set	
			{
				subjectAlternativeNames = value;
			}
		}
	}
}
