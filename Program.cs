
using firstProject.Data;
using firstProject.EndPoints;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connectionString);

var app = builder.Build();


app.MapGamesEndPoints();


app.Run();
