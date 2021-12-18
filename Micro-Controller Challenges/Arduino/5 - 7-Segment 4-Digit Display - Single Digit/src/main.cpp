#include <Arduino.h>

#define pinA 2
#define pinB 3
#define pinC 4
#define pinD 5
#define pinE 6
#define pinF 7
#define pinG 8
#define D 9

void setup() {
  
  pinMode(pinA, OUTPUT);
  pinMode(pinB, OUTPUT);     
  pinMode(pinC, OUTPUT);     
  pinMode(pinD, OUTPUT);     
  pinMode(pinE, OUTPUT);     
  pinMode(pinF, OUTPUT);     
  pinMode(pinG, OUTPUT);   
  pinMode(D, OUTPUT); 

}

void loop() {
  
  digitalWrite(pinA, LOW);
  digitalWrite(pinB, LOW);
  digitalWrite(pinC, LOW);
  digitalWrite(pinD, LOW);
  digitalWrite(pinE, LOW);
  digitalWrite(pinF, LOW);
  digitalWrite(pinG, LOW);
  digitalWrite(D, LOW);
  
}