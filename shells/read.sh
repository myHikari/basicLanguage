#!/bin/bash

read -t 7 -p "Enter Your Name In 7 Seconds: " name
if [ $? -eq 0 ]
then
	echo $name
elif [ $? -ne 0 ]
then
	echo "Input Your Name Fail!"
fi
