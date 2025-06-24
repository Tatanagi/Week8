using UnityEngine;

public class Coords
{
    float x;
    float y;
    float z;

    public Coords(float _x, float _y)
    {
        x = _x;
        y = _y;
        z = -1;     //Initial depth in z as -1
    }

    static public void DrawLine(Coords startPos, Coords endPos, float width, Color colour)
    {
        //Create a game object of 2 points
        GameObject line = new GameObject("Line" + startPos.ToString() + endPos.ToString());
        //Add component to render the line
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;       //To assign color
        lineRenderer.positionCount = 2;     //Two points define straight line
        //Define start position of line
        lineRenderer.SetPosition(0, new Vector3(startPos.x, startPos.y, startPos.z));
        //Define end position of line
        lineRenderer.SetPosition(1, new Vector3(endPos.x, endPos.y, endPos.z));
        lineRenderer.startWidth = width;        //Start width of line renderer
        lineRenderer.endWidth = width;      //End width of line renderer
    }

    static public void DrawPoint(Coords pointPosition, float width, Color colour)
    {
        //Create a game object of 2 points
        GameObject line = new GameObject("Line" + pointPosition.ToString());
        //Add component to render the line
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;       //To assign color
        lineRenderer.positionCount = 2;     //Two points define straight line
        //Define start position of line
        lineRenderer.SetPosition(0, new Vector3(pointPosition.x - width /3.0f, pointPosition.y - width /3.0f, pointPosition.z - width /3.0f));
        //Define end position of line
        lineRenderer.SetPosition(1, new Vector3(pointPosition.x + width /3.0f, pointPosition.y + width /3.0f, pointPosition.z + width /3.0f));
        lineRenderer.startWidth = width;        //Start width of line renderer
        lineRenderer.endWidth = width;      //End width of line renderer
    }
}