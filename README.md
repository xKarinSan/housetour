# 🏡House Tour
This is a simple C# Unity repository which simulates walking around inside a house. For some reason, I decided to allow the player to fire projectiles, and also introduce enemy turrets.

## Demo
https://github.com/xKarinSan/housetour/assets/47315402/9eff2180-8120-4dba-824c-1db138887e7c

## Directory
``` bash
housetour (root of the project)
├- Assets
  ├- External 
  ├- GameObjects 
    ├- House 
      ├- BuildingBlocks 
      ├- Items 
      ├- Rooms 
    ├- EnemyMobs 
    ├- Player 
    ├- Projectiles 
  ├- Materials 
  ├- Scenes
  ├- Scripts
    ├- General
    ├- Enemies 
    ├- Player 
    ├- Projectiles 
  ├- Sprites 
```
### More info on the directory
**NOTE: More info for each given folder below**

```Assets```
- ```External```: Assets from Unity Asset Store
- ```GameObjects```: Where most of the prefabs will be at
  - ```House```: Prefabs that are used to build a house in this project
    - ```BuildingBlocks```: Smaller 'blocks' that were used to build the house
    - ```Items```: Items that are to be placed in the house
    - ```Rooms```: Different types of rooms that are used to build the house
  - ```EnemyMobs```: Where to put the enemy mobs prefab
  - ```Player```: This is where the player prefab will be at
  - ```Projectiles```: This where the projectile prefabs will be at (for players and enemy mobs)
  - ```Materials```: Materials used across various GameObjects
  - ```Scenes```: Where scenes are stored; usually for different screens
  - ```Scripts```: Where the C# codes are located at
    - ```General```: Codes that are used across any GameObject
    - ```Enemies```: Codes that are used for any enemy mob prefabs
    - ```Player```: Codes that are used for any player prefabs
    - ```Projectiles```: Codes that are used for any projectiles
  - ```Sprites```: Any sprites used will be here

## Setup
1. Clone this repository
2. Run this project inside Unity (make sure to use the latest version whenever possible).
3. Have fun!

## Controls
1. Mouse movement to view various maps
2. WASD to move.
3. Shift to sprint.
4. Space bar to jump.
5. Left click to shoot.
