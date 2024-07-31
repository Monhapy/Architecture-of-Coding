using System;
using UnityEngine;

public class SamuraiAnimation : MonoBehaviour
{
   private Animator _samuraiAnimator;
   public int attackCount;
   private void Awake()
   {
      _samuraiAnimator = GetComponent<Animator>();
   }

   public void WalkAnim(float horizontalInput)
   {
      var animSpeed = Mathf.Abs(horizontalInput);
      _samuraiAnimator.SetFloat("Speed",animSpeed);
   }

   public void FirstAttackAnim()
   {
      _samuraiAnimator.SetTrigger("Attack");
   }
   public void SecondAttackAnim()
   {
      _samuraiAnimator.SetTrigger("Attack2");
   }

   public void AttackCountIncrease()
   {
      attackCount++;
   }

   public void AttackCountReset()
   {
      attackCount = 0;
   }
}
