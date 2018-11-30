/*
	[PROBLEM 3 OVERVIEW]
	Operating System: Windows
	Difficulty: Easy

	[PROBLEM 3 DESCRIPTION]
	The code below contains a unique take on the infamous "fizzbuzz" problem.
	You are tasked with modifying the 'system' variable in order to have getFavoriteFood() return a positive number.
	The current implementation below will output a negative number to stdout.
	An approach that involves "guess-and-check" is valid, but try to understand why certain inputs pass and why others fail.
	Feel free to reach out to your peers, tutors, or other online resources if you need additional help.

	[PROBLEM 3 FOOD MENU]
	#1: Spaghetti
	#2: Chicken Fettuccine
	#3: Cheeseburger
	#4: Pepperoni Pizza
	#5: Caeser Salad
*/

#include <stdio.h>
#include <stdlib.h>

typedef int(*StringToInt)(const char* text);

int getFavoriteFood(int* secret, StringToInt atoi)
{
	char* favorite_food = (char*)calloc(32, sizeof(char));

	for (int i = 0; i < 31; i++)
	{
		int counter = secret[i / 4] >> (i % 4 * 8) & 255;

		if (i % 3 == 0)
			favorite_food[i] = counter ^ 3;
		else if (i % 5 == 0)
			favorite_food[i] = counter ^ 5;
		else
			favorite_food[i] = counter ^ 15;
	}

	return atoi(favorite_food);
}

int main()
{
	int _secret[] = { 2004510576, 1635019371, 796274223, 774859054, 791687035, 758079528, 1684565101, 2194794 };
	int _system = '3';

	printf("Problem 3: Favorite Food is %d", getFavoriteFood(_secret, (StringToInt)system));

	return 0;
}

