using UnityEngine;
using System.Collections;

public class CubeTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Yellow))
        {
            Debug.Log("Yellow");
        }
        if (ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Blue))
        {
            Debug.Log("Blue");
        }
        if (ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Black))
        {
            Debug.Log("Black");
        }
        if (ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Left))
        {
            Debug.Log("Left");
        }
        if (ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Right))
        {
            Debug.Log("Right");
        }
    }
}
