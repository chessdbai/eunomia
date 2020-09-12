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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.AsyncSearchApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Eunomia.Nest
{
	///<summary>Descriptor for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
	public partial class AsyncSearchDeleteDescriptor : RequestDescriptorBase<AsyncSearchDeleteDescriptor, AsyncSearchDeleteRequestParameters, IAsyncSearchDeleteRequest>, IAsyncSearchDeleteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchDelete;
		///<summary>/_async_search/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public AsyncSearchDeleteDescriptor(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected AsyncSearchDeleteDescriptor(): base()
		{
		}

		// values part of the url path
		Id IAsyncSearchDeleteRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	///<summary>Descriptor for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
	public partial class AsyncSearchGetDescriptor : RequestDescriptorBase<AsyncSearchGetDescriptor, AsyncSearchGetRequestParameters, IAsyncSearchGetRequest>, IAsyncSearchGetRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchGet;
		///<summary>/_async_search/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public AsyncSearchGetDescriptor(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected AsyncSearchGetDescriptor(): base()
		{
		}

		// values part of the url path
		Id IAsyncSearchGetRequest.Id => Self.RouteValues.Get<Id>("id");
		// Request parameters
		///<summary>Specify the time interval in which the results (partial or final) for this search will be available</summary>
		public AsyncSearchGetDescriptor KeepAlive(Time keepalive) => Qs("keep_alive", keepalive);
		///<summary>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</summary>
		public AsyncSearchGetDescriptor TypedKeys(bool? typedkeys = true) => Qs("typed_keys", typedkeys);
		///<summary>Specify the time that the request should block waiting for the final response</summary>
		public AsyncSearchGetDescriptor WaitForCompletionTimeout(Time waitforcompletiontimeout) => Qs("wait_for_completion_timeout", waitforcompletiontimeout);
	}

	///<summary>Descriptor for Submit <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
	public partial class AsyncSearchSubmitDescriptor<TInferDocument> : RequestDescriptorBase<AsyncSearchSubmitDescriptor<TInferDocument>, AsyncSearchSubmitRequestParameters, IAsyncSearchSubmitRequest<TInferDocument>>, IAsyncSearchSubmitRequest<TInferDocument>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchSubmit;
		///<summary>/{index}/_async_search</summary>
		public AsyncSearchSubmitDescriptor(): this(typeof(TInferDocument))
		{
		}

		///<summary>/{index}/_async_search</summary>
		///<param name = "index">Optional, accepts null</param>
		public AsyncSearchSubmitDescriptor(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		Indices IAsyncSearchSubmitRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> AllowNoIndices(bool? allownoindices = true) => Qs("allow_no_indices", allownoindices);
		///<summary>Indicate if an error should be returned if there is a partial search failure or timeout</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> AllowPartialSearchResults(bool? allowpartialsearchresults = true) => Qs("allow_partial_search_results", allowpartialsearchresults);
		///<summary>Specify whether wildcard and prefix queries should be analyzed (default: false)</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> AnalyzeWildcard(bool? analyzewildcard = true) => Qs("analyze_wildcard", analyzewildcard);
		///<summary>The analyzer to use for the query string</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> Analyzer(string analyzer) => Qs("analyzer", analyzer);
		///<summary>The number of shard results that should be reduced at once on the coordinating node. This value should be used as the granularity at which progress results will be made available.</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> BatchedReduceSize(long? batchedreducesize) => Qs("batched_reduce_size", batchedreducesize);
		///<summary>The default operator for query string query (AND or OR)</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> DefaultOperator(DefaultOperator? defaultoperator) => Qs("default_operator", defaultoperator);
		///<summary>The field to use as default where no field prefix is given in the query string</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> Df(string df) => Qs("df", df);
		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> ExpandWildcards(ExpandWildcards? expandwildcards) => Qs("expand_wildcards", expandwildcards);
		///<summary>Whether specified concrete, expanded or aliased indices should be ignored when throttled</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> IgnoreThrottled(bool? ignorethrottled = true) => Qs("ignore_throttled", ignorethrottled);
		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> IgnoreUnavailable(bool? ignoreunavailable = true) => Qs("ignore_unavailable", ignoreunavailable);
		///<summary>Update the time interval in which the results (partial or final) for this search will be available</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> KeepAlive(Time keepalive) => Qs("keep_alive", keepalive);
		///<summary>Control whether the response should be stored in the cluster if it completed within the provided [wait_for_completion] time (default: false)</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> KeepOnCompletion(bool? keeponcompletion = true) => Qs("keep_on_completion", keeponcompletion);
		///<summary>Specify whether format-based query failures (such as providing text to a numeric field) should be ignored</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> Lenient(bool? lenient = true) => Qs("lenient", lenient);
		///<summary>The number of concurrent shard requests per node this search executes concurrently. This value should be used to limit the impact of the search on the cluster in order to limit the number of concurrent shard requests</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> MaxConcurrentShardRequests(long? maxconcurrentshardrequests) => Qs("max_concurrent_shard_requests", maxconcurrentshardrequests);
		///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> Preference(string preference) => Qs("preference", preference);
		///<summary>Query in the Lucene query string syntax</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> QueryOnQueryString(string queryonquerystring) => Qs("q", queryonquerystring);
		///<summary>Specify if request cache should be used for this request or not, defaults to true</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> RequestCache(bool? requestcache = true) => Qs("request_cache", requestcache);
		///<summary>
		/// A document is routed to a particular shard in an index using the following formula
		/// <para> shard_num = hash(_routing) % num_primary_shards</para>
		/// <para>Elasticsearch will use the document id if not provided. </para>
		/// <para>For requests that are constructed from/for a document NEST will automatically infer the routing key
		/// if that document has a <see cref = "Nest.JoinField"/> or a routing mapping on for its type exists on <see cref = "Nest.ConnectionSettings"/></para>
		///</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> Routing(Routing routing) => Qs("routing", routing);
		///<summary>Search operation type</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> SearchType(SearchType? searchtype) => Qs("search_type", searchtype);
		///<summary>Specify whether to return sequence number and primary term of the last modification of each hit</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> SequenceNumberPrimaryTerm(bool? sequencenumberprimaryterm = true) => Qs("seq_no_primary_term", sequencenumberprimaryterm);
		///<summary>Specific 'tag' of the request for logging and statistical purposes</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> Stats(params string[] stats) => Qs("stats", stats);
		///<summary>Specify which field to use for suggestions</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> SuggestField(Field suggestfield) => Qs("suggest_field", suggestfield);
		///<summary>Specify which field to use for suggestions</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> SuggestField(Expression<Func<TInferDocument, object>> field) => Qs("suggest_field", (Field)field);
		///<summary>Specify suggest mode</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> SuggestMode(SuggestMode? suggestmode) => Qs("suggest_mode", suggestmode);
		///<summary>How many suggestions to return in response</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> SuggestSize(long? suggestsize) => Qs("suggest_size", suggestsize);
		///<summary>The source text for which the suggestions should be returned</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> SuggestText(string suggesttext) => Qs("suggest_text", suggesttext);
		///<summary>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> TypedKeys(bool? typedkeys = true) => Qs("typed_keys", typedkeys);
		///<summary>Specify the time that the request should block waiting for the final response</summary>
		public AsyncSearchSubmitDescriptor<TInferDocument> WaitForCompletionTimeout(Time waitforcompletiontimeout) => Qs("wait_for_completion_timeout", waitforcompletiontimeout);
	}
}