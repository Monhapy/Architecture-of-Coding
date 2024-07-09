using UnityEngine;

public class Samurai: Character
{
    public sealed override float MoveSpeed { get; set; }
    public sealed override GameObject CharacterGo { get; set; }

    public Samurai(float samuraiMoveSpeed,GameObject samuraiGo)
    {
        MoveSpeed = samuraiMoveSpeed;
        CharacterGo = samuraiGo;

    }

    public override void Walk(float horizontalInput)
    {
        
        var position = CharacterGo.transform.position;
        position += new Vector3(horizontalInput,position.y,position.z) * (MoveSpeed * Time.deltaTime);
        CharacterGo.transform.position = position;
        
        SpriteFlip(horizontalInput);
    }

    private void SpriteFlip(float scale)
    {
        Vector3 flipVector = CharacterGo.transform.localScale;
        if (scale != 0)
        {
            flipVector.x = scale;
            CharacterGo.transform.localScale = flipVector;
        }
    }

    
    
}