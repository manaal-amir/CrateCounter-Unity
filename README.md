# Crate Counter Game (Prototype)

**Crate Counter** is a simple 3D Unity prototype where a plane drops crates and the player controls a boat to catch them. Points are earned for every crate caught, making it a fun way to practice Unity physics, triggers, and UI.  
<img width="1588" height="778" alt="image" src="https://github.com/user-attachments/assets/ea85d0a0-e52d-427c-8042-a36cca183b27" />


---

## Gameplay

- **Objective:** Catch as many crates as possible with the boat.
- **Mechanics:**
  - Crates drop from a plane at random positions.
  - The boat moves to catch crates.
  - Each caught crate increases the score.
  - Missed crates fall off the platform and are destroyed automatically.

---

## Features

- **Score Counter:** Displays points on the screen when crates are caught.
- **Automatic Cleanup:** Crates that fall below a certain height are destroyed.
- **3D Physics:** Uses Unity’s Rigidbody and Collider system for realistic crate falling and collision.

---

## Setup

Use the attached link to access the game prototype:  
https://play.unity.com/en/games/5caa31ae-3d83-408d-bc03-509513162f78/crate-counter  

---

## Scripts

- **Counter.cs:** Handles scoring when crates enter the boat’s trigger.
- **DestroyBelow.cs:** Automatically destroys crates that fall below a set Y-coordinate.

---

## Credits

- Developed as part of the **Unity Learn Junior Programmer course**.
- Unity assets used: basic 3D primitives for boat and crates.

---

## License

This project is a **prototype** and open-source for learning and personal use.
