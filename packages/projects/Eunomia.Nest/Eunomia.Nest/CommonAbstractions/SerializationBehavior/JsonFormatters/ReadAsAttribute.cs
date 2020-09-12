// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;

namespace Eunomia.Nest
{
	internal class ReadAsAttribute : Attribute
	{
		public ReadAsAttribute(Type readAs) => Type = readAs;

		public Type Type { get; }
	}
}