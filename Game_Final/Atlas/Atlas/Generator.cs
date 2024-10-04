using System;



namespace roomGenerator;
/// <summary>
/// Randomly generates rooms with items and hazords
/// Plugs into for loop for a set number of rooms (maybe based off difficulty)
/// Items stored will have a percentage chance of finding
/// </summary>
public class RoomGen
{
    public playerRooms(string[] args)
    {
        Dictionary<string, int> playerLocations = new Dictionary<string>
        {
            { "Traverse City, MI", 16 },
            { "Grand Haven, MI", 15 },
            { "Detroit, MI", 14 },
            { "South Bend, IN", 13 },
            { "Toledo. OH", 12 },
            { "Fort Wayne. IN", 11 },
            { "Indianapolis, IN", 10 },
            { "Columbus, OH", 9 },
            { "Cincinnati, OH", 8 },
            { "Louisville,KY", 7 },
            { "Lexington, KY", 6 },
            { "Nashville, TN", 5},
            { "Knoxville, TN", 4 },
            { "Asheville, NC", 3 },
            { "Winston-Salem, NC", 2 },
            { "Roanoke, VA", 1 },
            { "Charlotte, NC", 0 }

        };

        for (int i)
    }
}

public class ItemGen
{

}

public class HazGen
{
    
}

public class TravelGen
{
    // Needs North, South, East, West

    
}


public class TileGen
{
public static void mapGen(string[] args)
{
    for (int x = 0; x< 100; x++)
		{
			for (int y = 0; y< 100; y++) {


			}
		}
}

}
