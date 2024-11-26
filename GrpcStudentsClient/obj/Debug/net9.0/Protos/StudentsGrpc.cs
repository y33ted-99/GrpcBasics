// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/students.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcStudentsClient {
  /// <summary>
  /// The student service definition.
  /// </summary>
  public static partial class StudentRemote
  {
    static readonly string __ServiceName = "greet.StudentRemote";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcStudentsClient.StudentLookupModel> __Marshaller_greet_StudentLookupModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStudentsClient.StudentLookupModel.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcStudentsClient.StudentModel> __Marshaller_greet_StudentModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStudentsClient.StudentModel.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcStudentsClient.Reply> __Marshaller_greet_Reply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStudentsClient.Reply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcStudentsClient.Empty> __Marshaller_greet_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStudentsClient.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcStudentsClient.StudentList> __Marshaller_greet_StudentList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStudentsClient.StudentList.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStudentsClient.StudentLookupModel, global::GrpcStudentsClient.StudentModel> __Method_GetStudentInfo = new grpc::Method<global::GrpcStudentsClient.StudentLookupModel, global::GrpcStudentsClient.StudentModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStudentInfo",
        __Marshaller_greet_StudentLookupModel,
        __Marshaller_greet_StudentModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStudentsClient.StudentModel, global::GrpcStudentsClient.Reply> __Method_InsertStudent = new grpc::Method<global::GrpcStudentsClient.StudentModel, global::GrpcStudentsClient.Reply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InsertStudent",
        __Marshaller_greet_StudentModel,
        __Marshaller_greet_Reply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStudentsClient.StudentModel, global::GrpcStudentsClient.Reply> __Method_UpdateStudent = new grpc::Method<global::GrpcStudentsClient.StudentModel, global::GrpcStudentsClient.Reply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateStudent",
        __Marshaller_greet_StudentModel,
        __Marshaller_greet_Reply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStudentsClient.StudentLookupModel, global::GrpcStudentsClient.Reply> __Method_DeleteStudent = new grpc::Method<global::GrpcStudentsClient.StudentLookupModel, global::GrpcStudentsClient.Reply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteStudent",
        __Marshaller_greet_StudentLookupModel,
        __Marshaller_greet_Reply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStudentsClient.Empty, global::GrpcStudentsClient.StudentList> __Method_RetrieveAllStudents = new grpc::Method<global::GrpcStudentsClient.Empty, global::GrpcStudentsClient.StudentList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RetrieveAllStudents",
        __Marshaller_greet_Empty,
        __Marshaller_greet_StudentList);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcStudentsClient.StudentsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for StudentRemote</summary>
    public partial class StudentRemoteClient : grpc::ClientBase<StudentRemoteClient>
    {
      /// <summary>Creates a new client for StudentRemote</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public StudentRemoteClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StudentRemote that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public StudentRemoteClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected StudentRemoteClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected StudentRemoteClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.StudentModel GetStudentInfo(global::GrpcStudentsClient.StudentLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudentInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.StudentModel GetStudentInfo(global::GrpcStudentsClient.StudentLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStudentInfo, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.StudentModel> GetStudentInfoAsync(global::GrpcStudentsClient.StudentLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudentInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.StudentModel> GetStudentInfoAsync(global::GrpcStudentsClient.StudentLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStudentInfo, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.Reply InsertStudent(global::GrpcStudentsClient.StudentModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertStudent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.Reply InsertStudent(global::GrpcStudentsClient.StudentModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_InsertStudent, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.Reply> InsertStudentAsync(global::GrpcStudentsClient.StudentModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertStudentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.Reply> InsertStudentAsync(global::GrpcStudentsClient.StudentModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_InsertStudent, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.Reply UpdateStudent(global::GrpcStudentsClient.StudentModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateStudent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.Reply UpdateStudent(global::GrpcStudentsClient.StudentModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateStudent, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.Reply> UpdateStudentAsync(global::GrpcStudentsClient.StudentModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateStudentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.Reply> UpdateStudentAsync(global::GrpcStudentsClient.StudentModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateStudent, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.Reply DeleteStudent(global::GrpcStudentsClient.StudentLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteStudent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.Reply DeleteStudent(global::GrpcStudentsClient.StudentLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteStudent, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.Reply> DeleteStudentAsync(global::GrpcStudentsClient.StudentLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteStudentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.Reply> DeleteStudentAsync(global::GrpcStudentsClient.StudentLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteStudent, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.StudentList RetrieveAllStudents(global::GrpcStudentsClient.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RetrieveAllStudents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcStudentsClient.StudentList RetrieveAllStudents(global::GrpcStudentsClient.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RetrieveAllStudents, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.StudentList> RetrieveAllStudentsAsync(global::GrpcStudentsClient.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RetrieveAllStudentsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcStudentsClient.StudentList> RetrieveAllStudentsAsync(global::GrpcStudentsClient.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RetrieveAllStudents, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override StudentRemoteClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StudentRemoteClient(configuration);
      }
    }

  }
}
#endregion
