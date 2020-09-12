// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Runtime.CompilerServices;
using Elasticsearch.Net.Utf8Json;

namespace Eunomia.Nest
{
	internal static class JsonFormatterResolverExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IConnectionSettingsValues GetConnectionSettings(this IJsonFormatterResolver formatterResolver) =>
			((IJsonFormatterResolverWithSettings)formatterResolver).Settings;
	}
}