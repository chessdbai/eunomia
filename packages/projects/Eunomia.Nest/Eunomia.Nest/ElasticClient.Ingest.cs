// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.IngestApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Eunomia.Nest.Specification.IngestApi
{
	///<summary>
	/// Ingest APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticClient.Ingest"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class IngestNamespace : NamespacedClientProxy
	{
		internal IngestNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>DELETE</c> request to the <c>ingest.delete_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html</a>
		/// </summary>
		public DeletePipelineResponse DeletePipeline(Id id, Func<DeletePipelineDescriptor, IDeletePipelineRequest> selector = null) => DeletePipeline(selector.InvokeOrDefault(new DeletePipelineDescriptor(id: id)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>ingest.delete_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html</a>
		/// </summary>
		public Task<DeletePipelineResponse> DeletePipelineAsync(Id id, Func<DeletePipelineDescriptor, IDeletePipelineRequest> selector = null, CancellationToken ct = default) => DeletePipelineAsync(selector.InvokeOrDefault(new DeletePipelineDescriptor(id: id)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>ingest.delete_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html</a>
		/// </summary>
		public DeletePipelineResponse DeletePipeline(IDeletePipelineRequest request) => DoRequest<IDeletePipelineRequest, DeletePipelineResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>ingest.delete_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html</a>
		/// </summary>
		public Task<DeletePipelineResponse> DeletePipelineAsync(IDeletePipelineRequest request, CancellationToken ct = default) => DoRequestAsync<IDeletePipelineRequest, DeletePipelineResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ingest.get_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html</a>
		/// </summary>
		public GetPipelineResponse GetPipeline(Func<GetPipelineDescriptor, IGetPipelineRequest> selector = null) => GetPipeline(selector.InvokeOrDefault(new GetPipelineDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>ingest.get_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html</a>
		/// </summary>
		public Task<GetPipelineResponse> GetPipelineAsync(Func<GetPipelineDescriptor, IGetPipelineRequest> selector = null, CancellationToken ct = default) => GetPipelineAsync(selector.InvokeOrDefault(new GetPipelineDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ingest.get_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html</a>
		/// </summary>
		public GetPipelineResponse GetPipeline(IGetPipelineRequest request) => DoRequest<IGetPipelineRequest, GetPipelineResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>ingest.get_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html</a>
		/// </summary>
		public Task<GetPipelineResponse> GetPipelineAsync(IGetPipelineRequest request, CancellationToken ct = default) => DoRequestAsync<IGetPipelineRequest, GetPipelineResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ingest.processor_grok</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/grok-processor.html#grok-processor-rest-get">https://www.elastic.co/guide/en/elasticsearch/reference/master/grok-processor.html#grok-processor-rest-get</a>
		/// </summary>
		public GrokProcessorPatternsResponse GrokProcessorPatterns(Func<GrokProcessorPatternsDescriptor, IGrokProcessorPatternsRequest> selector = null) => GrokProcessorPatterns(selector.InvokeOrDefault(new GrokProcessorPatternsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>ingest.processor_grok</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/grok-processor.html#grok-processor-rest-get">https://www.elastic.co/guide/en/elasticsearch/reference/master/grok-processor.html#grok-processor-rest-get</a>
		/// </summary>
		public Task<GrokProcessorPatternsResponse> GrokProcessorPatternsAsync(Func<GrokProcessorPatternsDescriptor, IGrokProcessorPatternsRequest> selector = null, CancellationToken ct = default) => GrokProcessorPatternsAsync(selector.InvokeOrDefault(new GrokProcessorPatternsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ingest.processor_grok</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/grok-processor.html#grok-processor-rest-get">https://www.elastic.co/guide/en/elasticsearch/reference/master/grok-processor.html#grok-processor-rest-get</a>
		/// </summary>
		public GrokProcessorPatternsResponse GrokProcessorPatterns(IGrokProcessorPatternsRequest request) => DoRequest<IGrokProcessorPatternsRequest, GrokProcessorPatternsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>ingest.processor_grok</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/grok-processor.html#grok-processor-rest-get">https://www.elastic.co/guide/en/elasticsearch/reference/master/grok-processor.html#grok-processor-rest-get</a>
		/// </summary>
		public Task<GrokProcessorPatternsResponse> GrokProcessorPatternsAsync(IGrokProcessorPatternsRequest request, CancellationToken ct = default) => DoRequestAsync<IGrokProcessorPatternsRequest, GrokProcessorPatternsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>ingest.put_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/put-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/put-pipeline-api.html</a>
		/// </summary>
		public PutPipelineResponse PutPipeline(Id id, Func<PutPipelineDescriptor, IPutPipelineRequest> selector) => PutPipeline(selector.InvokeOrDefault(new PutPipelineDescriptor(id: id)));
		/// <summary>
		/// <c>PUT</c> request to the <c>ingest.put_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/put-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/put-pipeline-api.html</a>
		/// </summary>
		public Task<PutPipelineResponse> PutPipelineAsync(Id id, Func<PutPipelineDescriptor, IPutPipelineRequest> selector, CancellationToken ct = default) => PutPipelineAsync(selector.InvokeOrDefault(new PutPipelineDescriptor(id: id)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>ingest.put_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/put-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/put-pipeline-api.html</a>
		/// </summary>
		public PutPipelineResponse PutPipeline(IPutPipelineRequest request) => DoRequest<IPutPipelineRequest, PutPipelineResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>ingest.put_pipeline</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/put-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/put-pipeline-api.html</a>
		/// </summary>
		public Task<PutPipelineResponse> PutPipelineAsync(IPutPipelineRequest request, CancellationToken ct = default) => DoRequestAsync<IPutPipelineRequest, PutPipelineResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>ingest.simulate</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html</a>
		/// </summary>
		public SimulatePipelineResponse SimulatePipeline(Func<SimulatePipelineDescriptor, ISimulatePipelineRequest> selector = null) => SimulatePipeline(selector.InvokeOrDefault(new SimulatePipelineDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>ingest.simulate</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html</a>
		/// </summary>
		public Task<SimulatePipelineResponse> SimulatePipelineAsync(Func<SimulatePipelineDescriptor, ISimulatePipelineRequest> selector = null, CancellationToken ct = default) => SimulatePipelineAsync(selector.InvokeOrDefault(new SimulatePipelineDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>ingest.simulate</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html</a>
		/// </summary>
		public SimulatePipelineResponse SimulatePipeline(ISimulatePipelineRequest request) => DoRequest<ISimulatePipelineRequest, SimulatePipelineResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>ingest.simulate</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html</a>
		/// </summary>
		public Task<SimulatePipelineResponse> SimulatePipelineAsync(ISimulatePipelineRequest request, CancellationToken ct = default) => DoRequestAsync<ISimulatePipelineRequest, SimulatePipelineResponse>(request, request.RequestParameters, ct);
	}
}