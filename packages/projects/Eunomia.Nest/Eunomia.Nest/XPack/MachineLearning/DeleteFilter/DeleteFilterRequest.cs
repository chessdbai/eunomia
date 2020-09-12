// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

namespace Eunomia.Nest
{
	/// <summary>
	/// Deletes a machine learning filter
	/// </summary>
	[MapsApi("ml.delete_filter")]
	public partial interface IDeleteFilterRequest { }

	/// <inheritdoc cref="IDeleteFilterRequest"/>
	public partial class DeleteFilterRequest { }

	/// <inheritdoc cref="IDeleteFilterRequest"/>
	public partial class DeleteFilterDescriptor { }
}
