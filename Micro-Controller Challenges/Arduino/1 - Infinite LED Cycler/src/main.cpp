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
*/

#include <Arduino.h>
#define RED 6
#define GREEN 5
#define BLUE 3
#define DELAY 500

void setup() {

  pinMode(RED, OUTPUT);
  pinMode(GREEN, OUTPUT);
  pinMode(BLUE, OUTPUT);

}

void loop() {

  //RED
  digitalWrite(RED, HIGH);
  delay(DELAY);
  digitalWrite(RED, LOW);

  //YELLOW
  digitalWrite(RED, HIGH);
  digitalWrite(GREEN, HIGH);
  delay(DELAY);
  digitalWrite(RED, LOW);
  digitalWrite(GREEN, LOW);
  
  //GREEN
  digitalWrite(GREEN, HIGH);
  delay(DELAY);
  digitalWrite(GREEN, LOW);

  //CYAN
  digitalWrite(GREEN, HIGH);
  digitalWrite(BLUE, HIGH);
  delay(DELAY);
  digitalWrite(GREEN, LOW);
  digitalWrite(BLUE, LOW);

  //BLUE
  digitalWrite(BLUE, HIGH);
  delay(DELAY);
  digitalWrite(BLUE, LOW);

  //MAGENTA
  digitalWrite(RED, HIGH);
  digitalWrite(BLUE, HIGH);
  delay(DELAY);
  digitalWrite(RED, LOW);
  digitalWrite(BLUE, LOW);

}