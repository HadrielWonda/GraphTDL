var builder = WebApplication.CreateBuilder(args);

builder.Services
   .AddSingleton<Repositories>()
   .AddGraphQLserver()
   .AddQueryType<Query>();
   .AddMutationType<Mutation>();




var app = builder.Build();

app.MapGraphQL();

app.Run();
