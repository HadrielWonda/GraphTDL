var builder = WebApplication.CreateBuilder(args);

builder.Services
   .AddGraphQLserver()
   .AddQueryType<Query>();


   

var app = builder.Build();

app.MapGraphQL();

app.Run();
