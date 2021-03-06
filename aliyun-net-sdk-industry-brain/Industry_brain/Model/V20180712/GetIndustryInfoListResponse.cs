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

namespace Aliyun.Acs.industry_brain.Model.V20180712
{
	public class GetIndustryInfoListResponse : AcsResponse
	{

		private string requestId;

		private List<GetIndustryInfoList_IndustryInfoListItem> industryInfoList;

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

		public List<GetIndustryInfoList_IndustryInfoListItem> IndustryInfoList
		{
			get
			{
				return industryInfoList;
			}
			set	
			{
				industryInfoList = value;
			}
		}

		public class GetIndustryInfoList_IndustryInfoListItem
		{

			private string id;

			private string code;

			private string name;

			private string level;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}
		}
	}
}
