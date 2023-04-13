using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    // Any new state created will contain the following methods;
    public abstract void Enter();

    public abstract void Tick(float deltaTime);

    public abstract void Exit();
}
