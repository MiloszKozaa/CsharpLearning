using Game;
using Microsoft.Extensions.DependencyInjection;
using System;

//MainGame game = new MainGame(new StarterGame(new UserInputService(), new CurrentRound(), new RandomChoice(new RandomNumber()), new Comparisor(), new ShowWinner(new Comparisor())), new RandomNumber(), new UserInputService(), new CurrentRound());

IServiceCollection serviceCollection = new ServiceCollection();

serviceCollection.AddTransient<IStarterGame, StarterGame>();
serviceCollection.AddTransient<IShowWinner, ShowWinner>();
serviceCollection.AddTransient<IComparisor, Comparisor>();
serviceCollection.AddTransient<ICurrentRound, CurrentRound>();
serviceCollection.AddTransient<IMainGame, MainGame>();
serviceCollection.AddTransient<IRandomChoice, RandomChoice>();
serviceCollection.AddTransient<IRandomNumber, RandomNumber>();
serviceCollection.AddTransient<IUserInputService, UserInputService>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var mainGameResolved = serviceProvider.GetRequiredService<IMainGame>();

mainGameResolved.StartMainGame();

//game.StartMainGame();
