using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FriendlyBaseState : State
{
    protected FriendlyStateMachine stateMachine;

    public FriendlyBaseState(FriendlyStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
}
