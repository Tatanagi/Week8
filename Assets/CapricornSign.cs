using UnityEngine;

public class CapricornSign : MonoBehaviour
{
    // Define Capricorn star positions (based on image)
    Coords[] capricornStars =
    {
        new Coords(85, 30),    // Star 0
        new Coords(80, 20),    // Star 1
        new Coords(40, -80),   // Star 2
        new Coords(-35, -65),  // Star 3
        new Coords(-90, -15),  // Star 4
        new Coords(-35, -10),  // Star 5
        new Coords(0, 0),      // Star 6
    };

    // Define the lines between stars (using their index)
   int[,] connections =
{
    {1, 6},
    {6, 5},
    {5, 4},
    {4, 3},
    {3, 2},
    {2, 1},
    {1, 0}
};


    void Start()
    {
        // Draw axis lines for reference
        Coords.DrawLine(new Coords(-160, 0), new Coords(160, 0), 0.5f, Color.red);   // X-axis
        Coords.DrawLine(new Coords(0, -100), new Coords(0, 100), 0.5f, Color.green); // Y-axis

        // Draw each star
        foreach (var star in capricornStars)
        {
            Coords.DrawPoint(star, 2f, Color.white);
        }

        // Connect the stars with lines
        for (int i = 0; i < connections.GetLength(0); i++)
        {
            int from = connections[i, 0];
            int to = connections[i, 1];
            Coords.DrawLine(capricornStars[from], capricornStars[to], 1f, Color.white);
        }
    }
}
