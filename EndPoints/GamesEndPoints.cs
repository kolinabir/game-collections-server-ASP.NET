using firstProject.Dtos;

namespace firstProject.EndPoints;

public static class GamesEndPoints
{
    const string GetGameEndpointName = "GetGame";

    private static readonly List<GameDto> games = [
        new (1, "GTA V", "Action", 29.99m, new DateOnly(2013, 9, 17)),
    new (2, "FIFA 22", "Sport", 59.99m, new DateOnly(2021, 10, 1)),
    new (3, "Cyberpunk 2077", "RPG", 49.99m, new DateOnly(2020, 12, 10))
    ];

    public static RouteGroupBuilder MapGamesEndPoints(this WebApplication app)
    {
        var group = app.MapGroup("/games");
        app.MapGet("/", () => "Hello World!!!!!!");

        group.MapGet("", () => games);

        group.MapGet("/{id}", (int id) =>
        {
            GameDto? game =
            games.Find(game => game.Id == id);
            return game is null ? Results.NotFound() : Results.Ok(game);
        }).WithName(GetGameEndpointName);

        group.MapGet("/find/{name}", (string name) => games.Find((game) => game.Name == name));

        group.MapPost("", (CreateGameDto newGame) =>
        {
            GameDto game = new(
                games.Count + 1,
                newGame.Name,
                newGame.Genre,
                newGame.Price,
                newGame.ReleaseDate
            );
            games.Add(game);

            return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);

        }).WithParameterValidation();



        group.MapPut("/{id}", (int id, UpdateGameDto updatedGame) =>
        {
            var index = games.FindIndex(game => game.Id == id);
            games[index] = new GameDto(
                id, updatedGame.Name, updatedGame.Genre, updatedGame.Price, updatedGame.ReleaseDate
            );

            return Results.Accepted(GetGameEndpointName, new
            {
                id,
                updatedGame
            });
        }).WithParameterValidation();

        group.MapDelete("/{id}", (int id) =>
        {
            var index = games.FindIndex(game => game.Id == id);
            games.RemoveAt(index);

            return Results.NoContent();
        });

        return group;
    }
}
