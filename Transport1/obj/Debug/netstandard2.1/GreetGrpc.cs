// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: client/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Transport1 {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class TransportService
  {
    static readonly string __ServiceName = "Greet.TransportService";

    static readonly grpc::Marshaller<global::Transport1.User> __Marshaller_Greet_User = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Transport1.User.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Transport1.Response> __Marshaller_Greet_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Transport1.Response.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Transport1.Driver> __Marshaller_Greet_Driver = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Transport1.Driver.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Transport1.Bus> __Marshaller_Greet_Bus = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Transport1.Bus.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Transport1.Route> __Marshaller_Greet_Route = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Transport1.Route.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Transport1.History> __Marshaller_Greet_History = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Transport1.History.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Transport1.RouteRequest> __Marshaller_Greet_RouteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Transport1.RouteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Transport1.HistoryRequest> __Marshaller_Greet_HistoryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Transport1.HistoryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Transport1.UserRequest> __Marshaller_Greet_UserRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Transport1.UserRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Transport1.User, global::Transport1.Response> __Method_AddUser = new grpc::Method<global::Transport1.User, global::Transport1.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddUser",
        __Marshaller_Greet_User,
        __Marshaller_Greet_Response);

    static readonly grpc::Method<global::Transport1.Driver, global::Transport1.Response> __Method_AddDriver = new grpc::Method<global::Transport1.Driver, global::Transport1.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddDriver",
        __Marshaller_Greet_Driver,
        __Marshaller_Greet_Response);

    static readonly grpc::Method<global::Transport1.Bus, global::Transport1.Response> __Method_AddBus = new grpc::Method<global::Transport1.Bus, global::Transport1.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddBus",
        __Marshaller_Greet_Bus,
        __Marshaller_Greet_Response);

    static readonly grpc::Method<global::Transport1.Route, global::Transport1.Response> __Method_AddRoute = new grpc::Method<global::Transport1.Route, global::Transport1.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddRoute",
        __Marshaller_Greet_Route,
        __Marshaller_Greet_Response);

    static readonly grpc::Method<global::Transport1.History, global::Transport1.Response> __Method_AddHistory = new grpc::Method<global::Transport1.History, global::Transport1.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddHistory",
        __Marshaller_Greet_History,
        __Marshaller_Greet_Response);

    static readonly grpc::Method<global::Transport1.RouteRequest, global::Transport1.Route> __Method_GetRouteList = new grpc::Method<global::Transport1.RouteRequest, global::Transport1.Route>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetRouteList",
        __Marshaller_Greet_RouteRequest,
        __Marshaller_Greet_Route);

    static readonly grpc::Method<global::Transport1.HistoryRequest, global::Transport1.History> __Method_GetHistoryList = new grpc::Method<global::Transport1.HistoryRequest, global::Transport1.History>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetHistoryList",
        __Marshaller_Greet_HistoryRequest,
        __Marshaller_Greet_History);

    static readonly grpc::Method<global::Transport1.UserRequest, global::Transport1.User> __Method_GetOneOfUser = new grpc::Method<global::Transport1.UserRequest, global::Transport1.User>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOneOfUser",
        __Marshaller_Greet_UserRequest,
        __Marshaller_Greet_User);

    static readonly grpc::Method<global::Transport1.User, global::Transport1.Response> __Method_UpdateUser = new grpc::Method<global::Transport1.User, global::Transport1.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateUser",
        __Marshaller_Greet_User,
        __Marshaller_Greet_Response);

    static readonly grpc::Method<global::Transport1.Driver, global::Transport1.Response> __Method_UpdateDriver = new grpc::Method<global::Transport1.Driver, global::Transport1.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateDriver",
        __Marshaller_Greet_Driver,
        __Marshaller_Greet_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Transport1.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for TransportService</summary>
    public partial class TransportServiceClient : grpc::ClientBase<TransportServiceClient>
    {
      /// <summary>Creates a new client for TransportService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TransportServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TransportService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TransportServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TransportServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TransportServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Transport1.Response AddUser(global::Transport1.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Transport1.Response AddUser(global::Transport1.User request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddUser, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddUserAsync(global::Transport1.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddUserAsync(global::Transport1.User request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddUser, null, options, request);
      }
      public virtual global::Transport1.Response AddDriver(global::Transport1.Driver request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddDriver(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Transport1.Response AddDriver(global::Transport1.Driver request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddDriver, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddDriverAsync(global::Transport1.Driver request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddDriverAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddDriverAsync(global::Transport1.Driver request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddDriver, null, options, request);
      }
      public virtual global::Transport1.Response AddBus(global::Transport1.Bus request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddBus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Transport1.Response AddBus(global::Transport1.Bus request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddBus, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddBusAsync(global::Transport1.Bus request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddBusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddBusAsync(global::Transport1.Bus request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddBus, null, options, request);
      }
      public virtual global::Transport1.Response AddRoute(global::Transport1.Route request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddRoute(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Transport1.Response AddRoute(global::Transport1.Route request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddRoute, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddRouteAsync(global::Transport1.Route request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddRouteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddRouteAsync(global::Transport1.Route request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddRoute, null, options, request);
      }
      public virtual global::Transport1.Response AddHistory(global::Transport1.History request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddHistory(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Transport1.Response AddHistory(global::Transport1.History request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddHistory, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddHistoryAsync(global::Transport1.History request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddHistoryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> AddHistoryAsync(global::Transport1.History request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddHistory, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Transport1.Route> GetRouteList(global::Transport1.RouteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRouteList(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Transport1.Route> GetRouteList(global::Transport1.RouteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetRouteList, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Transport1.History> GetHistoryList(global::Transport1.HistoryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetHistoryList(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Transport1.History> GetHistoryList(global::Transport1.HistoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetHistoryList, null, options, request);
      }
      public virtual global::Transport1.User GetOneOfUser(global::Transport1.UserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOneOfUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Transport1.User GetOneOfUser(global::Transport1.UserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOneOfUser, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.User> GetOneOfUserAsync(global::Transport1.UserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOneOfUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.User> GetOneOfUserAsync(global::Transport1.UserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOneOfUser, null, options, request);
      }
      public virtual global::Transport1.Response UpdateUser(global::Transport1.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Transport1.Response UpdateUser(global::Transport1.User request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateUser, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> UpdateUserAsync(global::Transport1.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> UpdateUserAsync(global::Transport1.User request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateUser, null, options, request);
      }
      public virtual global::Transport1.Response UpdateDriver(global::Transport1.Driver request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateDriver(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Transport1.Response UpdateDriver(global::Transport1.Driver request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateDriver, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> UpdateDriverAsync(global::Transport1.Driver request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateDriverAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Transport1.Response> UpdateDriverAsync(global::Transport1.Driver request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateDriver, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TransportServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TransportServiceClient(configuration);
      }
    }

  }
}
#endregion
