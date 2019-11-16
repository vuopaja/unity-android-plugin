package com.vuopaja.unityplugintutorial;

import java.util.Random;

public class RandomNumber
{
    public static int Generate(int maxValue)
    {
        Random random = new Random();
        return random.nextInt(maxValue);
    }
}
