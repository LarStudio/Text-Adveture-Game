using UnityEngine;

public abstract class BaseState
{ 
  public abstract void EnterState(StateManager G);

  public abstract void UpdateState(StateManager G);
}

