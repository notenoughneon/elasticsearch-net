
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

///This file contains all the typed enums that the client rest api spec exposes.
///This file is automatically generated from https://github.com/elasticsearch/elasticsearch-rest-api-spec
///Generated of commit 
namespace Nest
{
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConsistencyOptions 
	{
		  [EnumMember(Value = "one")]
		One,
		[EnumMember(Value = "quorum")]
		Quorum,
		[EnumMember(Value = "all")]
		All
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReplicationOptions 
	{
		  [EnumMember(Value = "sync")]
		Sync,
		[EnumMember(Value = "async")]
		Async
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LevelOptions 
	{
		  [EnumMember(Value = "cluster")]
		Cluster,
		[EnumMember(Value = "indices")]
		Indices,
		[EnumMember(Value = "shards")]
		Shards
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum WaitForStatusOptions 
	{
		  [EnumMember(Value = "green")]
		Green,
		[EnumMember(Value = "yellow")]
		Yellow,
		[EnumMember(Value = "red")]
		Red
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TypeOptions 
	{
		  [EnumMember(Value = "cpu")]
		Cpu,
		[EnumMember(Value = "wait")]
		Wait,
		[EnumMember(Value = "block")]
		Block
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IgnoreIndicesOptions 
	{
		  [EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "missing")]
		Missing
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VersionTypeOptions 
	{
		  [EnumMember(Value = "internal")]
		Internal,
		[EnumMember(Value = "external")]
		External
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DefaultOperatorOptions 
	{
		  [EnumMember(Value = "AND")]
		And,
		[EnumMember(Value = "OR")]
		Or
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OpTypeOptions 
	{
		  [EnumMember(Value = "index")]
		Index,
		[EnumMember(Value = "create")]
		Create
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FormatOptions 
	{
		  [EnumMember(Value = "detailed")]
		Detailed,
		[EnumMember(Value = "text")]
		Text
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SearchTypeOptions 
	{
		  [EnumMember(Value = "query_then_fetch")]
		QueryThenFetch,
		[EnumMember(Value = "query_and_fetch")]
		QueryAndFetch,
		[EnumMember(Value = "dfs_query_then_fetch")]
		DfsQueryThenFetch,
		[EnumMember(Value = "dfs_query_and_fetch")]
		DfsQueryAndFetch,
		[EnumMember(Value = "count")]
		Count,
		[EnumMember(Value = "scan")]
		Scan
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SuggestModeOptions 
	{
		  [EnumMember(Value = "missing")]
		Missing,
		[EnumMember(Value = "popular")]
		Popular,
		[EnumMember(Value = "always")]
		Always
	}
	
}
 