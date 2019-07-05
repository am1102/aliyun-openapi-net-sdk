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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class VerifyCustomOcrTemplateResponseUnmarshaller
    {
        public static VerifyCustomOcrTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			VerifyCustomOcrTemplateResponse verifyCustomOcrTemplateResponse = new VerifyCustomOcrTemplateResponse();

			verifyCustomOcrTemplateResponse.HttpResponse = context.HttpResponse;
			verifyCustomOcrTemplateResponse.RequestId = context.StringValue("VerifyCustomOcrTemplate.RequestId");
			verifyCustomOcrTemplateResponse.RecognizeInfo = context.StringValue("VerifyCustomOcrTemplate.RecognizeInfo");
			verifyCustomOcrTemplateResponse.ImageUrl = context.StringValue("VerifyCustomOcrTemplate.ImageUrl");
        
			return verifyCustomOcrTemplateResponse;
        }
    }
}
