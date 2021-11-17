#THIS IS PYTHON CODE

import RPi.GPIO as GPIO
import time
import sys
import os

GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(23, GPIO.OUT)
GPIO.setup(21, GPIO.OUT)
GPIO.setup(26, GPIO.IN)
GPIO.output(21, GPIO.LOW)

for q in range (5):
	print("ON")
	GPIO.output(23,GPIO.HIGH)

	time.sleep(4)

	print("OFF")
	GPIO.output(23,GPIO.LOW)

	time.sleep(1)
	if(GPIO.input(26) == 1):
		GPIO.output(21, GPIO.HIGH)

	else:
		GPIO.output(21, GPIO.LOW)

GPIO.cleanup