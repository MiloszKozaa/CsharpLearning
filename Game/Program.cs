using Game;
using System;

MainGame game = new MainGame(new StarterGame(new UserInputService(), new CurrentRound(), new RandomChoice(new RandomNumber()), new Comparisor(), new ShowWinner(new Comparisor())), new RandomNumber(), new UserInputService(), new CurrentRound());



game.StartMainGame();
