#!/bin/bash

s=0
for((i=1;i<=100;i++))
do
	s=$[$s+$i]
done

echo $s

echo "$ * 的情况"
for i in $*
do
	echo "agrs[$i]"
done

echo "‘$ *’ 的情况"
for i in "$*"
do
	echo "args[$i]"
done

echo "$ @ 的情况"
for i in $@
do
	echo "args[$i]"
done

echo "‘$ @’ 的情况"
for i in "$@"
do
	echo "args[$i]"
done
