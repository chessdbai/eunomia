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
using Elasticsearch.Net.Specification.DanglingIndicesApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Eunomia.Nest
{
	///<summary>Descriptor for DeleteDanglingIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-gateway-dangling-indices.html</para></summary>
	public partial class DeleteDanglingIndexDescriptor : RequestDescriptorBase<DeleteDanglingIndexDescriptor, DeleteDanglingIndexRequestParameters, IDeleteDanglingIndexRequest>, IDeleteDanglingIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesDeleteDanglingIndex;
		///<summary>/_dangling/{index_uuid}</summary>
		///<param name = "indexUuid">this parameter is required</param>
		public DeleteDanglingIndexDescriptor(IndexUuid indexUuid): base(r => r.Required("index_uuid", indexUuid))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteDanglingIndexDescriptor(): base()
		{
		}

		// values part of the url path
		IndexUuid IDeleteDanglingIndexRequest.IndexUuid => Self.RouteValues.Get<IndexUuid>("index_uuid");
		// Request parameters
		///<summary>Must be set to true in order to delete the dangling index</summary>
		public DeleteDanglingIndexDescriptor AcceptDataLoss(bool? acceptdataloss = true) => Qs("accept_data_loss", acceptdataloss);
		///<summary>Specify timeout for connection to master</summary>
		public DeleteDanglingIndexDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout</summary>
		public DeleteDanglingIndexDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}

	///<summary>Descriptor for ImportDanglingIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-gateway-dangling-indices.html</para></summary>
	public partial class ImportDanglingIndexDescriptor : RequestDescriptorBase<ImportDanglingIndexDescriptor, ImportDanglingIndexRequestParameters, IImportDanglingIndexRequest>, IImportDanglingIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesImportDanglingIndex;
		///<summary>/_dangling/{index_uuid}</summary>
		///<param name = "indexUuid">this parameter is required</param>
		public ImportDanglingIndexDescriptor(IndexUuid indexUuid): base(r => r.Required("index_uuid", indexUuid))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ImportDanglingIndexDescriptor(): base()
		{
		}

		// values part of the url path
		IndexUuid IImportDanglingIndexRequest.IndexUuid => Self.RouteValues.Get<IndexUuid>("index_uuid");
		// Request parameters
		///<summary>Must be set to true in order to import the dangling index</summary>
		public ImportDanglingIndexDescriptor AcceptDataLoss(bool? acceptdataloss = true) => Qs("accept_data_loss", acceptdataloss);
		///<summary>Specify timeout for connection to master</summary>
		public ImportDanglingIndexDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout</summary>
		public ImportDanglingIndexDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}

	///<summary>Descriptor for List <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-gateway-dangling-indices.html</para></summary>
	public partial class ListDanglingIndicesDescriptor : RequestDescriptorBase<ListDanglingIndicesDescriptor, ListDanglingIndicesRequestParameters, IListDanglingIndicesRequest>, IListDanglingIndicesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesList;
	// values part of the url path
	// Request parameters
	}
}