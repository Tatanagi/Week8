using UnityEngine;

public class DrawLines : MonoBehaviour
{
    // Define Capricorn star positions based on image reference
    Coords[] capricornStars =
    {
        new Coords(85, 30),   // Star 0 (leftmost)
        new Coords(80, 20),   // Star 1
        new Coords(40, -80),   // Star 2
        new Coords(-35, -65),   // Star 3 (center top)
        new Coords(-90, -15),    // Star 4 (upper right)
        new Coords(-35, -10),    // Star 5
        new Coords(0, 0),     // Star 6 (bottom right)
    };

    // Define the lines connecting the stars (index-based)
    int[,] connections =
    {
        {0, 1},
        {1, 2},
        {2, 3},
        {3, 4},
        {4, 5},
        {5, 6},
        {6, 7},
        {7, 8},
        {8, 0}
    };

    void Start()
    {
        // Draw X and Y axes for reference
        Coords.DrawLine(new Coords(-160, 0), new Coords(160, 0), 0.5f, Color.red);   // X-axis
        Coords.DrawLine(new Coords(0, -100), new Coords(0, 100), 0.5f, Color.green); // Y-axis

        // Draw points and connecting lines
        foreach (var star in capricornStars)
        {
            Coords.DrawPoint(star, 2f, Color.yellow);
        }

        for (int i = 0; i < connections.GetLength(0); i++)
        {
            Coords.DrawLine(
                capricornStars[connections[i, 0]],
                capricornStars[connections[i, 1]],
                1.5f,
                Color.yellow
            );
        }
    }
}
