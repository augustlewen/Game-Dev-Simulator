public enum Skill_Design
{
    Content,
    Mechanic,
    Level,
    World,
    Narrative,
    Movement,
    System,
    AI,
    UI,
    UX,
    Audio,

    NumberOfTypes
}


public enum Skill_Tech
{
    Gameplay,
    System,
    Physic,
    AI,
    Network,
    UI,
    Graphic,
    Audio,
    GameTool,

    NumberOfTypes
}

public enum Skill_Art
{
    Concept,
    Environment,
    Character,
    UI,
    Animation,
    VFX,

    NumberOfTypes
}

// public enum Skill
// {
//     ContentDesign,
//     MechanicDesign,
//     LevelDesign,
//     WorldDesign,
//     NarrativeDesign,
//     MovementDesign,
//     SystemDesign,
//     AIDesign,
//     UIDesign,
//     UXDesign,
//     AudioDesign,
//     GameplayTech,
//     SystemTech,
//     PhysicTech,
//     AITech,
//     NetworkTech,
//     UITech,
//     GraphicTech,
//     AudioTech,
//     GameToolTech,
//     ConceptArt,
//     EnvironmentArt,
//     CharacterArt,
//     UIArt,
//     AnimationArt,
//     VFXArt
// }

[System.Serializable]
public class WorkerSkill
{
    public Skill_Design skillDesign;
    public Skill_Tech skillTech;
    public Skill_Art skillArt;
    public int level;
}
