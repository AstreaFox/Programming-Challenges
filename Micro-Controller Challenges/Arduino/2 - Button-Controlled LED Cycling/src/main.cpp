/*
Components Used:
1 x Arduino Uno
1 x Serial USB Cable
1 x RGB LED
3 x 330 Ohm Resistor
1 x Short Red Jumper Cable
1 x Short Green Jumper Cable
1 x Short Blue Jumper Cable
1 x Short Black Jumper Cable
1 x Breadboard

1 x 2K Ohm Resistor
1 x Push Button
1 x Short Orange Wire
1 x Short Red Wire
1 x Short Black Wire
*/

#include <Arduino.h>
#define RED 6
#define GREEN 5
#define BLUE 3
#define DELAY 500

#define PUSH_BUTTON 2

int cycle_counter = 0;

void waitKey(int button) {

  while (digitalRead(button) == LOW) {};
  delay(20);
  while (digitalRead(button) == HIGH) {};
  delay(20);
  return;

}

void resetColours(){

  digitalWrite(RED, LOW);
  digitalWrite(GREEN, LOW);
  digitalWrite(BLUE, LOW);

}

void cycleColours() {
  
  cycle_counter++;
  if (cycle_counter > 6) cycle_counter = 1;

  switch (cycle_counter){

    case 1:
      //RED
      resetColours();
      digitalWrite(RED, HIGH);
      break;
    
    case 2:
      //YELLOW
      resetColours();
      digitalWrite(RED, HIGH);
      digitalWrite(GREEN, HIGH);
      break;

    case 3:
      //GREEN
      resetColours();
      digitalWrite(GREEN, HIGH);
      break;

    case 4:
      //CYAN
      resetColours();
      digitalWrite(GREEN, HIGH);
      digitalWrite(BLUE, HIGH);
      break;

    case 5:
      //BLUE
      resetColours();
      digitalWrite(BLUE, HIGH);
      break;
    
    case 6:
      //MAGENTA
      resetColours();
      digitalWrite(RED, HIGH);
      digitalWrite(BLUE, HIGH);
      break;

  }

}

void setup() {

  Serial.begin(9600);

  pinMode(RED, OUTPUT);
  pinMode(GREEN, OUTPUT);
  pinMode(BLUE, OUTPUT);

  pinMode(PUSH_BUTTON, INPUT);

}

void loop() {

  if (digitalRead(PUSH_BUTTON) == HIGH) {

    cycleColours();
    waitKey(PUSH_BUTTON);

  }

}