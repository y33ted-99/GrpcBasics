using Grpc.Net.Client;
using GrpcStudentsClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register the gRPC client
builder.Services.AddGrpcClient<StudentRemote.StudentRemoteClient>(options =>
{
    options.Address = new Uri("http://localhost:5233"); // Update with your gRPC server address
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
