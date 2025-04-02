int Fan = 10; // servo pin
int ScentOne = 3; // atomizer 1 pin (with lavender essential oil)
int ScentTwo = 0; // atomizer 2 pin (with orange essential oil)




void setup() {
  // Allow allocation of all timers
  // ESP32PWM::allocateTimer(0);
  // ESP32PWM::allocateTimer(1);
  // ESP32PWM::allocateTimer(2);
  // ESP32PWM::allocateTimer(3);
  Serial.begin(460800);
  // pwm.attachPin(APin, freq, 10); // 1KHz 10 bits - commented out for now
  pinMode(Fan, OUTPUT);
  pinMode(ScentOne, OUTPUT);
  pinMode(ScentTwo, OUTPUT);




  Serial.println("Smells!");
  digitalWrite(Fan, HIGH);
}


void loop() {
  // Check if data is available


  if (Serial.available() > 0) {
    String command = Serial.readStringUntil('\n');
    command.trim();


    // if (command == "FAN") {
    //   Serial.println("Action from Unity!");
    //   digitalWrite(Fan, HIGH);
    //   delay(3000);
    //   digitalWrite(Fan, LOW);
    // }


    if (command == "ScentOne") {
      Serial.println("Action from Unity!");
      digitalWrite(ScentOne, HIGH);
      delay(6000);
      digitalWrite(ScentOne, LOW);
    }


    if (command == "ScentTwo") {
      Serial.println("Action from Unity!");
      digitalWrite(ScentTwo, HIGH);
      delay(6000);
      digitalWrite(ScentTwo, LOW);
    }
   
    else {
      Serial.print("Unknown command received: ");
      Serial.println(command);
    }
  }
}