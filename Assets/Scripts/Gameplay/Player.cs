
using System;
public static class Player
{
	public static int score;
	public static int lives;
	public static string playerName;
	public static int pointsPerKill;
	public static float shieldTime ;
	public static float shieldModifier;
	public static float maxShield;
	public static float resCooldown;
	public static bool isAlive = true;
	public static bool shieldsUp = false;
	public static int level = 0;
	public static float countdown;
	public static bool countdownNeeded;
	public static float pushScore;
	public static bool immortal;
	public static ControllerType inputType = ControllerType.drum;
	public static bool pushMode;
	
	public static void addToShield()
	{
		if (shieldTime < maxShield) 
		{
			shieldTime += shieldModifier;
		}
		else
		{
			shieldTime = maxShield;
		}
	}
	
	public static void addScore(int asteroidType)
	{
		score += pointsPerKill * asteroidType;
	}

	public static void loseLife()
	{
		lives--;

		isAlive = false;
	}

	public static void respawn()
	{
		isAlive = true;
	}
}

public enum ControllerType
{
	keyboard,
	drum,
	controller
}