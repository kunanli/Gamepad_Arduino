using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoControl_2 : MonoBehaviour {

    public float speed;
    private float amountToMove;
    /*
    private byte blackButtonMask = 1;
    private byte blueButtonMask = 2;
    private byte yellowButtonMask = 4;
    */
    public enum ButtonCode
    {
        Yellow = 4,
        Blue = 2,
        Black = 1, 
        Left = 8,
        Right = 16
    }

    SerialPort sp = new SerialPort("COM3", 9600);

    static int buttonStateData;
	// Use this for initialization
	void Start () {
        sp.Open();
        sp.ReadTimeout = 100;
	}
	
	// Update is called once per frame
	void Update () {
        amountToMove = speed * Time.deltaTime;
        if (sp.IsOpen)
        {
            try
            {
                buttonStateData = sp.ReadByte();
               // Debug.Log(IsButtonDown(data, yellowButtonMask));

                //MoveCar(data);
                //print(string.Format("{0:X}", data));
            }
            catch (System.Exception)
            {
                throw;
            }
        }
	}

    // Decode the button from the input data using the button code mask (to make it readable for unity)
    public static bool IsButtonDown(ButtonCode buttonCode)
    {
        return ((int)buttonCode & buttonStateData) == (int)buttonCode;
    }

  /*  void MoveCar(int Direction)
    {
        if (Direction == 1)
        {
            transform.Translate(Vector3.left * amountToMove, Space.World);
        }
        if (Direction == 2)
        {
            transform.Translate(Vector3.right * amountToMove, Space.World);
        }
    } */

}
