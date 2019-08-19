﻿
using Newtonsoft.Json;

namespace Couchbase.N1QL
{
    public class QueryPlan
    {
        /// <summary>
        /// Gets the name of the query plan generated by the server.
        /// </summary>
        /// <value>
        /// The name of the query plan.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("signature")]
        public object Signature { get; set; }

        [JsonProperty("encoded_plan")]
        public string EncodedPlan { get; set; }

        [JsonProperty("operator")]
        public object Operator { get; set; }
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2017 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion