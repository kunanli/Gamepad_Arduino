

// Arduino pin numbers
const int SW_pin = 2; // digital pin connected to switch output
const int X_pin = 1; // analog pin connected to X output
const int Y_pin = 2; // analog pin connected to Y output

const int button1Pin = 3; //pushbutton 1 pin
const int button2Pin = 4; //pushbutton 2 pin
const int button3Pin = 5; //pushbutton 3 pin

 
void setup() {
  Serial.begin(9600);
  pinMode(SW_pin, INPUT);
  digitalWrite(SW_pin, HIGH);
  

  pinMode(button1Pin, INPUT);
  pinMode(button2Pin, INPUT);
  pinMode(button3Pin, INPUT);

 
}
 
void loop() {
  //For controlling Joysticker
  /*Serial.print("Switch:  ");
  Serial.print(digitalRead(SW_pin));
  Serial.print("\n");
  Serial.print("X-axis: ");
  Serial.print(analogRead(X_pin));
  Serial.print("\n");
  Serial.print("Y-axis: ");
  Serial.println(analogRead(Y_pin));
  Serial.print("\n\n");
  */
  delay(50);
  // Use just one variable to encode the state for all the buttons. 
  // Each bit in the byte represents a button
  byte buttonStates = 0;
  //For controlling pushbuttons
  int button1State, button2State, button3State;
  
  button1State = digitalRead(button1Pin);
     if (button1State == LOW)
        {
         //Serial.print("Accelerating");
          buttonStates = buttonStates | 1;
          //Serial.write(1);
          //Serial.flush();
          //delay (20);
        }
    
  button2State = digitalRead(button2Pin);
     if (button2State == LOW)
        {
          buttonStates = buttonStates | 2;

          //Serial.print("Brake");
         // Serial.write(2);
         // Serial.flush();
          //delay (20);
        }
        
  button3State = digitalRead(button3Pin);
     if (button3State == LOW)
        {
                   buttonStates = buttonStates | 4;

         // Serial.print("Nitro");
       
        }
    if(analogRead(X_pin) > 600)
    {
      buttonStates = buttonStates | 8;
    }
    if(analogRead(X_pin) < 400)
    {
      buttonStates = buttonStates | 16;
    }
        Serial.write(buttonStates);
}

  

