using UnityEngine;

public abstract class SamuraiBaseState
{
   protected SamuraiStateManager _stateManager;
   protected abstract Samurai Samurai { get; set; }
   protected abstract Animator SamuraiAnimator { get; set; }
   protected abstract CharacterInput SamuraiInput { get; set; }
   protected SamuraiBaseState(SamuraiStateManager stateManager)
   {
      _stateManager = stateManager;
   }
   public abstract void EnterState();
   public abstract void UpdateState();
   public abstract void ExitState();
   public abstract void CheckState();

}
