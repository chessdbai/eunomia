// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

namespace Eunomia.Nest
{
	/// <summary>
	/// This action will set the index to be read-only.
	/// </summary>
	/// <remarks>
	/// Phases allowed: warm.
	/// </remarks>
	public interface IReadOnlyLifecycleAction : ILifecycleAction { }

	public class ReadOnlyLifecycleAction : IReadOnlyLifecycleAction { }

	public class ReadOnlyLifecycleActionDescriptor
		: DescriptorBase<ReadOnlyLifecycleActionDescriptor, IReadOnlyLifecycleAction>, IReadOnlyLifecycleAction { }
}
