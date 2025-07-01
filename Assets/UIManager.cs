using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor.Build.Content;
public class UIManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject tank, fuel;
    public Text tankposition, fuelpositionText;
    public ObjectManager fuelPosition;
    void Start()
    {
        tankposition.text = tank.transform.position + "";
        fuelPosition = fuel.GetComponent<ObjectManager>();
        fuelpositionText.text = fuelPosition.objPosition + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
