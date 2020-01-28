#!/bin/bash/ -x
echo "Enter the value of a, b and c, and find roots...."
read a
read b
read c
	delta=$(echo "$a" "$b" "$c" | awk '{print (($2*$2)-(4*$1*$3))}')
	root1=$(echo "$a" "$b" "$delta" | awk '{print (sqrt($3)-($2))/(2*$1)}')
	root2=$(echo "$a" "$b" "$delta" | awk '{print (qrt($3)+($2))/(2*$1)}')
printf "$root1  $root2\n"
n1=1
n2=2
n=$(echo "n1" "n2" | awk '{print (10-1000)}')
echo $n
