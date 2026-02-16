using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UI_State
{
    public static bool IsUIOpen { get; set; }

    public static void ResetState()
    {
        IsUIOpen = false;
    }
}
