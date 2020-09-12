// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

namespace Eunomia.Nest
{
	/// <inheritdoc />
	public class FielddataSettings
	{
		/// <inheritdoc />
		public Time CacheExpire { get; internal set; }

		/// <inheritdoc />
		public string CacheSize { get; internal set; }
	}
}
