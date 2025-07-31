# Goober-Nexus---GMTK-2025

This file contains the design and puzzle layout for the GMTK 2025 game "Goober Nexus".

## Game Design Overview

The game is a 2D puzzle-platformer with two playable characters: The Criminal and The Detective. The MVP will focus on a single warehouse level, played through from two different perspectives.

### Core Concepts

*   **Loaded Levels:** Each floor of the warehouse is a separate, self-contained Unity Scene. This prevents backtracking and keeps the logic for each floor clean.
*   **Player Guidance ("Yellow Brick Road"):** Each step in a puzzle must provide a clear clue or breadcrumb that logically points the player to the next step. This is achieved through in-game notes, item descriptions, and environmental storytelling.
*   **Persistent State Management:** A persistent `GameProgressManager` object will exist across all scenes. It will track the major choices made by the Criminal (e.g., which solution they used to complete a floor). This data will be used to alter the level layout, block paths, and place evidence for the Detective's playthrough.

---

## Minimum Viable Product (MVP) Goals

The goal for the MVP is to deliver a complete, polished slice of the game that demonstrates all core mechanics.

*   **Playable Characters:** Both "The Criminal" and "The Detective" are playable.
*   **Complete Level:** The full warehouse level, from "Outside" to the "Third Floor," is implemented for both characters.
*   **Criminal Gameplay:**
    *   Each of the four floors contains the three distinct puzzle paths as outlined in the puzzle layout.
    *   All puzzles are fully functional.
*   **Detective Gameplay:**
    *   The path taken by the Criminal in the previous playthrough is blocked off.
    *   Evidence corresponding to the Criminal's actions is present in the level for the Detective to find.
*   **Narrative Cliffhanger:** The game culminates in two "Celeste-esque" in-engine cutscenes:
    *   **Criminal:** A Mexican standoff in the secret meeting room.
    *   **Detective:** The moment of discovery that points to the next major location.

---

## Puzzle Layout: The Criminal

### Floor 0: Outside Warehouse
*Goal: Get into the 1st floor of the warehouse.*

*   **Solution 1:** Push a box to create a makeshift ramp to climb into a high window.
*   **Solution 2:** Find a hidden garage door code to open the main loading bay.
*   **Solution 3:** Find a key (e.g., under a doormat) to unlock a side door.

### Floor 1: Warehouse First Floor
*Goal: Get to the second floor.*

*   **Solution 1 (Phone Puzzle):**
    1.  Find a phone number written on a bathroom wall.
    2.  Find an employee name from a clock-in machine.
    3.  Use the phone in the entry hallway to call the number and provide the name, receiving a security code in return.
*   **Solution 2 (Janitor's Key):**
    1.  Find a keyring.
    2.  Use a key to enter the janitor's closet (requires a small stealth section).
    3.  Find a 2nd-floor keycard and a disguise. The disguise allows for a safe return trip without stealth.
*   **Solution 3 (GM's Office):**
    1.  Find a post-it note with a combination lock PIN.
    2.  Use the PIN on a locker in the locker room to get the GM's keycard.
    3.  Access the GM's office and press a button to unlock access to the second floor.

### Floor 2: Warehouse Second Floor
*Goal: Get to the third floor.*

*   **Solution 1 (Utility Box):**
    1.  Find a utility manual in an office with a security password written on it.
    2.  Use the manual to operate a utility box, shutting off power to a security room and enabling backup power.
    3.  Use the password on a pin pad in the now-accessible security room to unlock the 3rd floor.
*   **Solution 2 (Crane Puzzle):**
    1.  Find a crane manual in an office.
    2.  Solve a crane puzzle to move a large shipping container, creating a bridge.
    3.  Navigate a stealth section after the bridge to reach the 3rd-floor access.
*   **Solution 3 (Bathroom Secret):**
    1.  Find a hidden note in an office.
    2.  The note leads to a "secret" hidden within a bathroom (e.g., a loose tile, a key behind a cistern).
    3.  The secret allows the player to bypass the 3rd-floor keycard reader.

### Floor 3: Warehouse Third Floor
*Goal: Reach the secret meeting room.*

*   **Solution 1 (Elevator Puzzle):**
    1.  Find and activate the main power switch for an old elevator.
    2.  Find the elevator manual.
    3.  Solve a lever-based minigame to get the elevator working.
    4.  Use the elevator to create a bridge to the final area.
*   **Solution 2 (Office Rumors):**
    1.  Find a creative office with whiteboard notes.
    2.  Decipher the notes to learn about a rumor of a spare keycard held by a specific higher-up.
    3.  Find the keycard and use it to enter the final room.
*   **Solution 3 (Executive Trail):**
    1.  Follow a trail of clues found in meeting notes across several executive offices.
    2.  This involves a stealth sequence.
    3.  The final clue reveals the pin code for the door to the secret room.
