using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class CarArduinoControl : MonoBehaviour {

        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Right) ? -1.0f : 0.0f;
            h = ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Left) ? 1.0f : h;

            float v = ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Blue) ? 1.0f : 0.0f; ;
            //v = ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Black) ? -0.5f : 0.0f; ;
#if !MOBILE_INPUT
        float handbrake = ArduinoControl_2.IsButtonDown(ArduinoControl_2.ButtonCode.Yellow) ? 1.0f : 0.0f; ;
        m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }

