#!/bin/bash

echo "using system function"

echo "basename"
basename $PWD/$0 .sh
echo "dirname"
dirname $PWD/$0

echo "useing user-defined function"
function sum()
{
	s=0
	s=$[ $1 + $2 ]
	echo "$s"
}

read -p "Enter A First Number: " num1
read -p "Enter A Second Number: " num2
sum $num1 $num2;
