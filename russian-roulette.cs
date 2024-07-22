using System;

	public class RussianRoulette
	{
		public static void Main ()
		{
		//Define the chambers for the gun and their sizes and content
		int[] playerGun = new int[6] {0,0,0,0,0,0};
		int[] computerGun = new int[6] {0,0,0,0,0,0};
	
		//get random chamber
		Random rnd = new Random();
		int playerChamber = rnd.Next(0,6); 
		int computerChamber = rnd.Next (0,6);

		//Debug statements to check which chamber gets the bullet
//		Console.WriteLine ("Player chamber: " + playerChamber);
//		Console.WriteLine ("Computer chamber: " + computerChamber);

		//insert bullet into the chamber
		playerGun[playerChamber] = 1;
		computerGun[computerChamber] = 1;

		//Game loop
		Console.WriteLine("Welcome to the shortest game of life and death....in your life.");
		Console.WriteLine("Let's get started, shall we?");
		Console.WriteLine("Computer is up first: ");
		//gameOver is the exit condition for the game loop
		bool gameOver = false;
		int chamberPull = 0;
		int round = 1;
		//We keep these values outside of the loop or they will be reassigned each time - learned this the hard way :D
		do {
			if(computerGun[chamberPull] == 1){
				Console.WriteLine("Bang - Computer is ded, you win on round: " + round);
				gameOver = true;
			} else if(playerGun[chamberPull] == 1){
				Console.WriteLine("Click - Computer survived");
				Console.WriteLine("Bang - You ded on round: " + round);
				gameOver = true;
			} else{
				Console.WriteLine("Click - You both survived round " + round);
				chamberPull++;
				round++;
			}
		} while (gameOver == false);
		}
	}