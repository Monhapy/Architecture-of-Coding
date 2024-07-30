using UnityEngine;

public class SamuraiMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;
    public Transform samuraiTransform;
    public Rigidbody2D samuraiRb;
    public Animator samuraiAnimator;
    public void Walk(float horizontalInput)
    {
        var walkInput = horizontalInput;
        samuraiTransform.position += new Vector3(walkInput, 0f, 0f)*moveSpeed;
        var animspeed = Mathf.Abs(horizontalInput);
        samuraiAnimator.SetFloat("Speed",animspeed);

        if (horizontalInput != 0)
        {
            var samuraiTransformLocalScale = samuraiTransform.localScale;
            samuraiTransformLocalScale.x = horizontalInput;
            samuraiTransform.localScale = samuraiTransformLocalScale;
        }
    }

    public void Jump(bool verticalInput,bool isGround)
    {
        if (verticalInput && isGround)
        {
            samuraiRb.AddForce(new Vector2(0f,jumpSpeed),ForceMode2D.Impulse);
        }
    }

    
}