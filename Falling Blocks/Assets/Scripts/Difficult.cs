using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficult
{
    static float secondsToMaxDifficult = 60f;

    public static float GetSecondsToMaxDifficult()
    {
        return Mathf.Clamp01(Time.time / secondsToMaxDifficult);
    }
}
