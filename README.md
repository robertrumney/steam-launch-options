# Steam launch options for Unity

## Overview

This project includes functionality to start a Unity game in either windowed or full-screen mode based on command line arguments provided at launch. This feature is handy for managing display settings dynamically via external launchers, such as Steam and serves as an example of how to communicate with command line arguments from a Unity application for any kind of purpose.

## Setup

### Configuring Unity Settings

Before running the project, ensure the player settings in Unity are configured to allow for both windowed and full-screen modes:

1. **Open Player Settings**:
   - Go to `Edit > Project Settings > Player`.

2. **Adjust Screen Settings**:
   - In the **Resolution and Presentation** section, set **Allow Fullscreen Switch** to `true` to allow toggling between full-screen and windowed modes.
   - Ensure **Resizable Window** is checked if you want the window to be resizable in windowed mode.

### Usage

To control the window mode via command line:

- **Windowed Mode**: Add `-windowed` to the command line arguments when launching the game.
- **Full-Screen Mode**: Launch the game without any specific arguments, or adjust the script to recognize a specific full-screen command.
