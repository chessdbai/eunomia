// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Runtime.Serialization;

namespace Eunomia.Nest
{
	public class NamedPolicy : EnrichPolicy
	{
		[DataMember(Name = "name")]
		public string Name { get; set; }
	}

	public class NamedPolicyMetadata
	{
		[DataMember(Name = "config")]
		public NamedPolicyConfig Config { get; internal set; }
	}

	public class NamedPolicyConfig
	{
		[DataMember(Name = "geo_match")]
		public NamedPolicy GeoMatch { get; internal set; }

		[DataMember(Name = "match")]
		public NamedPolicy Match { get; internal set; }
	}
}