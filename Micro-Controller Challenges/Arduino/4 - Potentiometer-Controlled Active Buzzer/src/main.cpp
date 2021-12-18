#include <Arduino.h>

const int POTENTIOMETER = A0;
#define BUZZER 3
#define ANAL_THRESHOLD 500

void setup() {

  Serial.begin(9600);
  pinMode(BUZZER, OUTPUT);

}

void loop() {

  int val = (analogRead(POTENTIOMETER) / 100);

  digitalWrite(BUZZER, HIGH);
  delay(val);

  digitalWrite(BUZZER, LOW);
  delay(val);

}