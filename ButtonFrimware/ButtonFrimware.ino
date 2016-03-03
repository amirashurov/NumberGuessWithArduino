const int BUTTON_YES = 2;
const int BUTTON_NO = 4;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);  
}

void loop() {
  // put your main code here, to run repeatedly:
  if (digitalRead(BUTTON_YES)==HIGH){
    Serial.println('y');
    delay(400);
  }
  if (digitalRead(BUTTON_NO)==HIGH){
    Serial.println('n');
    delay(400);
  }
  

}
