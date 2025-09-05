# Green City Scavenger

**Student Code:** 22125097
**Full Name:** Vo Nhu Thien 


## Game Overview

Green City Scavenger is an educational 3D first-person simulation game that promotes environmental awareness through interactive waste management gameplay. Players navigate a dynamic urban environment, collecting various types of recyclable materials and sorting them into appropriate recycling bins while learning proper waste disposal practices.

### Core Gameplay
- **Environmental Education**: Learn about different types of recyclable materials (Metal, Glass, Plastic, Paper)
- **Physics-Based Interactions**: Realistic item throwing and collection mechanics
- **Scoring System**: Earn points for correct sorting, lose points for mistakes
- **Urban Exploration**: Navigate a living city populated with AI-controlled NPCs
- **Inventory Management**: Strategic collection with limited carrying capacity

## Technical Features

### Player Systems
- **Advanced Movement Controller**: Walking, sprinting, crouching, jumping, and ladder climbing
- **First-Person Camera**: Smooth mouse-look controls with adjustable sensitivity
- **Inventory System**: Stack-based item storage with real-time capacity display
- **Physics-Based Throwing**: Power-adjustable throwing with recoil effects

### AI & Environment
- **NavMesh AI NPCs**: Intelligent non-player characters that patrol city routes
- **Waypoint Navigation**: NPCs follow realistic urban movement patterns
- **Audio Integration**: Contextual sound effects for footsteps, jumping, and feedback

### Game Mechanics
- **Waste Sorting Challenge**: Four distinct recycling categories with immediate feedback
- **Dynamic Scoring**: Real-time score tracking with visual updates
- **Pause System**: Complete game state management with menu navigation
- **Scene Management**: Multiple levels including main menu and tutorial

## Development Environment

**Unity Version:** 2022.3.x LTS  
**Target Platform:** Windows/Mac Desktop  
**Programming Language:** C#  
**Input System:** Unity Input System Package  
**Physics:** Unity Physics Engine with NavMesh

## Project Structure

Assets/
├── Scripts/
│   ├── Player/          # PlayerMovement, PlayerCamera, PlayerInventory
│   ├── Game/           # ScoreManager, ItemCounter, GameEventsManager
│   ├── AI/             # NPCController and navigation scripts
│   ├── UI/             # MainMenu, PauseMenu interface scripts
│   └── Items/          # Item, BinScript, PickUpDropThrow
├── Art/
│   ├── Models/         # 3D meshes and character models
│   ├── Textures/       # Image files and materials
│   └── Animations/     # Character and object animations
├── Audio/
│   ├── SFX/           # Sound effects
│   ├── Music/         # Background music
│   └── Voice/         # Voice acting and narration
└── Scenes/
    ├── MainMenu        # Game entry point
    ├── GameLevel       # Main gameplay scene
    └── Tutorial        # Player instruction scene

## Key Scripts

- **BinScript.cs**: Handles waste sorting logic and collision detection
- **PlayerMovement.cs**: Comprehensive player locomotion system
- **NPCController.cs**: AI navigation using Unity NavMesh
- **PlayerInventory.cs**: Stack-based item collection and management
- **ScoreManager.cs**: Game scoring and UI updates
- **GameEventsManager.cs**: Centralized event system architecture

## Learning Objectives

1. **Environmental Awareness**: Understanding recycling categories and proper waste disposal
2. **Problem Solving**: Strategic thinking for efficient collection and sorting
3. **Hand-Eye Coordination**: Physics-based throwing and navigation skills
4. **Resource Management**: Inventory planning and capacity optimization

## Installation & Setup

1. Clone this repository
2. Open project in Unity 2022.3.x LTS or later
3. Import required packages:
   - Unity Input System
   - TextMeshPro
   - AI Navigation (NavMesh)
4. Open `MainMenu` scene to start
5. Build and run for target platform

## Controls

| Action | Input |
|--------|-------|
| Move | WASD |
| Look | Mouse |
| Jump | Space |
| Sprint | Left Shift |
| Crouch | Left Ctrl |
| Pick Up | Right Mouse Button |
| Throw | Left Mouse Button |
| Pause | P or Escape |

## Resource References

### Development Tools
- **Unity Technologies**: Unity Engine 2022.3 LTS
- **Microsoft**: Visual Studio Community
- **Unity Technologies**: Input System Package
- **Unity Technologies**: NavMesh AI System

### Educational Resources
- Unity Learn Platform - Character Controller tutorials
- Unity Documentation - Physics and NavMesh systems
- Game Development patterns and best practices
- Environmental education resources for recycling categories

### Asset References
- 3D Models for character: mixamo.com 
- 3D asset for terrain: https://assetstore.unity.com/packages/3d/environments/urban/white-city-76766#content
    https://assetstore.unity.com/packages/3d/environments/urban/toony-tiny-city-demo-176087
- Audio Files: pixabay.com
- Texture: Canvas for image design
### Technical References
- Unity C# Scripting Reference
- Component-based architecture patterns
- Event-driven programming in Unity
- Physics simulation and collision detection

## Future Development

- Multiplayer cooperative mode
- Extended urban environments
- Advanced NPC interactions
- Mobile platform adaptation
- Achievement and progression systems
- Real-world recycling data integration

