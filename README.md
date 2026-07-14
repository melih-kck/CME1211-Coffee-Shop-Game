# Coffee Shop Game

Coffee Shop Game is a console-based C# management game developed for the CME1211 Algorithms and Programming course. The player manages a small coffee shop by purchasing supplies, preparing products, completing orders, and tracking the daily budget.

## Features

- Coffee package purchasing and brewing
- Croissant package purchasing and preparation
- Stock and budget tracking
- Daily order limits
- Manual and automatic end-of-day operations
- Coffee machine and croissant tray cleanup rules
- Clear warnings for invalid quantities and insufficient stock

## Game Menu

1. Buy coffee package
2. Brew coffee
3. Sell cup(s) of coffee
4. Buy package(s) of croissant
5. Open one package of croissant
6. Sell croissant(s)
7. End the day
8. Quit the game

The game starts with a capital of `100Z`. Each coffee package costs `5Z` and contains three shots. Each croissant package costs `10Z` and contains five croissants.

## End-of-Day Rules

- At least three completed orders are required to end a day manually.
- A day ends automatically after six completed orders.
- Fresh coffee is cleared at the end of every day.
- Croissants on the tray are cleared at the end of every second day.
- Unused coffee shots and unopened croissant packages carry over to the next day.

## Requirements

- .NET 8.0 SDK or a newer compatible SDK

## Run

Open a terminal in the project folder and run:

```bash
dotnet run
```

Enter the menu choices and requested quantities as whole numbers.

## Project Structure

```text
CME1211-Coffee-Shop-Game/
|-- 2024510061_melih_kucuk.cs
|-- CME1211.CoffeeShop.csproj
|-- README.md
`-- .gitignore
```
