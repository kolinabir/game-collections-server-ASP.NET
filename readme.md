# FirstProject

This is a sample ASP.NET project that demonstrates basic CRUD operations for a game collection.

## Prerequisites

- .NET SDK
- Visual Studio Code or any other code editor

## Getting Started

1. Clone the repository: `git clone https://github.com/kolinabir/Game-Server-dotnet`
2. Navigate to the project directory: `cd first-project`
3. Restore dependencies: `dotnet restore`
4. Build the project: `dotnet build`
5. Run the project: `dotnet run`

## Endpoints

### GET /

Returns a simple "Hello World!" message.

### GET /games

Returns a list of all games.

### GET /games/{id}

Returns the game with the specified ID.

### GET /games/find/{name}

Returns the game with the specified name.

### POST /games

Creates a new game with the provided details.

### PUT /games/{id}

Updates the game with the specified ID.

### DELETE /games/{id}

Deletes the game with the specified ID.

## DTOs

### GameDto

Represents a game with the following properties:

- `Id` (int): The unique identifier of the game.
- `Name` (string): The name of the game.
- `Genre` (string): The genre of the game.
- `Price` (decimal): The price of the game.
- `ReleaseDate` (DateOnly): The release date of the game.

### CreateGameDto

Represents the data required to create a new game with the following properties:

- `Name` (string): The name of the game.
- `Genre` (string): The genre of the game.
- `Price` (decimal): The price of the game.
- `ReleaseDate` (DateOnly): The release date of the game.

### UpdateGameDto

Represents the data required to update an existing game with the following properties:

- `Name` (string): The updated name of the game.
- `Genre` (string): The updated genre of the game.
- `Price` (decimal): The updated price of the game.
- `ReleaseDate` (DateOnly): The updated release date of the game.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, please open an issue or submit a pull request.
