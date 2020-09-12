// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Collections.Generic;
using System.Runtime.Serialization;
using Elasticsearch.Net.Utf8Json;

namespace Eunomia.Nest
{
	[JsonFormatter(typeof(ResolvableDictionaryResponseFormatter<RecoveryStatusResponse, IndexName, RecoveryStatus>))]
	public class RecoveryStatusResponse : DictionaryResponseBase<IndexName, RecoveryStatus>
	{
		[IgnoreDataMember]
		public IReadOnlyDictionary<IndexName, RecoveryStatus> Indices => Self.BackingDictionary;
	}
}
