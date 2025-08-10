# Meteorite Game

**A simple 2D Unity game created for practice and learning.**

---

## Overview

`meteorite-game` is a 2D practice project built to learn and implement basic mechanics in Unity. The player controls a small character that moves left and right to dodge meteorites falling from above. As time passes, the game becomes more challenging with faster or more frequent meteorites.

## Gameplay

* Move left or right.
* Use the **Dash** ability to temporarily increase movement speed.
* Meteorites fall from the top of the screen; colliding with one results in a loss.
* On death, the game returns to the main menu, where the player can choose to **start a new game** or **exit**.

## Controls

* **Desktop / PC**:

  * `A` / `Left Arrow` — Move left
  * `D` / `Right Arrow` — Move right
  * `Left Shift` or `Space` — Dash (temporary speed boost)

(For mobile, you can use touch buttons for left/right movement and a dash button — if you want guidance on adding touch controls, I can provide sample code.)

## Features

* Simple and great for practicing movement, dash, and collision handling.
* Gradually increasing difficulty (meteor spawn rate or speed).
* Returns to main menu on death.
* Basic scoring system (can be based on survival time or dodged meteors).

## Suggested Project Structure

```
Assets/
  Scenes/
    MainMenu.unity
    Game.unity
  Scripts/
    PlayerController.cs
    MeteoriteSpawner.cs
    GameManager.cs
  Prefabs/
    Player.prefab
    Meteorite.prefab
  Art/
  Audio/
```

## Unity Version

Recommended: **Unity 6.1** (or any version compatible with your setup). Using a different version may require adjustments to physics or API usage.

## How to Run

1. Clone or download the repository.
2. Open the folder in Unity Hub (Open a project → select folder).
3. Open the `MainMenu.unity` scene and press Play.

### Build Instructions

* **Windows**: `File -> Build Settings -> PC, Mac & Linux Standalone` → Build
* **Android**: `File -> Build Settings -> Android` (Make sure Android Build Support is installed in Unity Hub)

## Contributing

If you want to add new features (e.g., advanced scoring, combat mechanics, improved animations, or mobile controls), fork the project and submit a Pull Request. Please open an issue to discuss your idea before making major changes.

## License

This project is released under the **MIT License** — free to use, modify, and distribute.

```
MIT License
Copyright (c) [YEAR] [Your Name]
```

(Replace the name and year as needed.)

