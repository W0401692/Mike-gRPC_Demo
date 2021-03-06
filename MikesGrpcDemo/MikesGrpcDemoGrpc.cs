// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mikes_grpc_demo.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Mikesgrpcdemo {
  public static partial class MikesGrpcDemo
  {
    static readonly string __ServiceName = "mikesgrpcdemo.MikesGrpcDemo";

    static readonly grpc::Marshaller<global::Mikesgrpcdemo.Name> __Marshaller_Name = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mikesgrpcdemo.Name.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mikesgrpcdemo.ContactInfo> __Marshaller_ContactInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mikesgrpcdemo.ContactInfo.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mikesgrpcdemo.GroceryRequest> __Marshaller_GroceryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mikesgrpcdemo.GroceryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mikesgrpcdemo.GroceryResponse> __Marshaller_GroceryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mikesgrpcdemo.GroceryResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Mikesgrpcdemo.Name, global::Mikesgrpcdemo.ContactInfo> __Method_GetContactInfo = new grpc::Method<global::Mikesgrpcdemo.Name, global::Mikesgrpcdemo.ContactInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetContactInfo",
        __Marshaller_Name,
        __Marshaller_ContactInfo);

    static readonly grpc::Method<global::Mikesgrpcdemo.GroceryRequest, global::Mikesgrpcdemo.GroceryResponse> __Method_GetGroceries = new grpc::Method<global::Mikesgrpcdemo.GroceryRequest, global::Mikesgrpcdemo.GroceryResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetGroceries",
        __Marshaller_GroceryRequest,
        __Marshaller_GroceryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Mikesgrpcdemo.MikesGrpcDemoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MikesGrpcDemo</summary>
    public abstract partial class MikesGrpcDemoBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Mikesgrpcdemo.ContactInfo> GetContactInfo(global::Mikesgrpcdemo.Name request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetGroceries(global::Mikesgrpcdemo.GroceryRequest request, grpc::IServerStreamWriter<global::Mikesgrpcdemo.GroceryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MikesGrpcDemo</summary>
    public partial class MikesGrpcDemoClient : grpc::ClientBase<MikesGrpcDemoClient>
    {
      /// <summary>Creates a new client for MikesGrpcDemo</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MikesGrpcDemoClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MikesGrpcDemo that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MikesGrpcDemoClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MikesGrpcDemoClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MikesGrpcDemoClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Mikesgrpcdemo.ContactInfo GetContactInfo(global::Mikesgrpcdemo.Name request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetContactInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Mikesgrpcdemo.ContactInfo GetContactInfo(global::Mikesgrpcdemo.Name request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetContactInfo, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Mikesgrpcdemo.ContactInfo> GetContactInfoAsync(global::Mikesgrpcdemo.Name request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetContactInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Mikesgrpcdemo.ContactInfo> GetContactInfoAsync(global::Mikesgrpcdemo.Name request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetContactInfo, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Mikesgrpcdemo.GroceryResponse> GetGroceries(global::Mikesgrpcdemo.GroceryRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetGroceries(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Mikesgrpcdemo.GroceryResponse> GetGroceries(global::Mikesgrpcdemo.GroceryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetGroceries, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MikesGrpcDemoClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MikesGrpcDemoClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MikesGrpcDemoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetContactInfo, serviceImpl.GetContactInfo)
          .AddMethod(__Method_GetGroceries, serviceImpl.GetGroceries).Build();
    }

  }
}
#endregion
