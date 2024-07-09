using UnityEngine;

public abstract class Character
{
    public abstract float MoveSpeed { get; set; }
    public abstract GameObject CharacterGo { get; set; }
    
    public abstract void Walk(float horizontalInput);
    
}