using System;
using UnityEngine;

public class LaunchOptions : MonoBehaviour
{
    private void Start()
    {
        string[] args = Environment.GetCommandLineArgs();

        // Look for the '-windowed' argument
        bool isWindowed = Array.IndexOf(args, "-windowed") >= 0;

        if (isWindowed)
        {
            // Set the game to run in windowed mode
            Screen.fullScreen = false;
            Screen.SetResolution(1280, 720, false); // You can adjust this resolution
        }
        else
        {
            // Set the game to run in full-screen mode
            Screen.fullScreen = true;
            Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
        }
    }
}
