using UnityEngine;

public class SamuraiMovement : MonoBehaviour
{
    public float moveSpeed;
    public Transform samuraiTransform;
    
    public void Walk(float horizontalInput)
    {
        var walkInput = horizontalInput;
        var newMoveSpeed = moveSpeed / 100;
        samuraiTransform.position += new Vector3(walkInput, 0f, 0f)*newMoveSpeed;

        if (horizontalInput != 0)
        {
            var samuraiTransformLocalScale = samuraiTransform.localScale;
            samuraiTransformLocalScale.x = horizontalInput;
            samuraiTransform.localScale = samuraiTransformLocalScale;
        }
    }
}