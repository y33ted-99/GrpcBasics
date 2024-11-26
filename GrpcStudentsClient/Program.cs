using Grpc.Net.Client;
using GrpcStudentsClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:5233");

/*
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "Jane Bond" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
*/

var sClient = new StudentRemote.StudentRemoteClient(channel);

/*
// create a student
var sInput = new StudentLookupModel { StudentId = 3 };
var sReply = await sClient.GetStudentInfoAsync(sInput);
Console.WriteLine($"{sReply.StudentId}, {sReply.FirstName}  {sReply.LastName}, {sReply.School}");
*/

/*
// ########################### Insert Student
StudentModel newStudent = new StudentModel()
{
   FirstName = "John",
   LastName = "Baker",
   School = "Nursing",
};
var replyNewStudent = sClient.InsertStudent(newStudent);
Console.WriteLine($"Result={replyNewStudent.Result} & isOk={replyNewStudent.IsOk}");
*/

/*
// ########################### Update Student
StudentModel updateStudent = new StudentModel()
{
   StudentId = 7,
   FirstName = "Jane",
   LastName = "Jones",
   School = "Pharmacy",
};
var replyUpdateStudent = sClient.UpdateStudent(updateStudent);
Console.WriteLine($"Result={replyUpdateStudent.Result} & isOk={replyUpdateStudent.IsOk}");
*/

/*
var deleteLookupModel = new StudentLookupModel();
deleteLookupModel.StudentId = 7;
var replyDeleteStudent = sClient.DeleteStudent(deleteLookupModel);
*/

var replyAllStudents = sClient.RetrieveAllStudents(new Empty());
foreach (var item in replyAllStudents.Items)
{
    Console.WriteLine($"{item.StudentId} {item.FirstName} {item.LastName} {item.School}");
}

Console.ReadLine();
