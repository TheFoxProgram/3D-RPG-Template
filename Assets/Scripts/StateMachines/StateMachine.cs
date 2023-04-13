using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    private State currentState;

    public void SwitchState(State newState)
    {
        if (currentState != null)
        {
            currentState.Exit();
        }

        currentState = newState;

        if (currentState != null)
        {
            currentState.Enter();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // Shorthand version of the if statement:currentState?.{Called Method}};
        // Will not work on monobehaviors or scriptable objects...
        if (currentState != null)
        {
            currentState.Tick(Time.deltaTime);
        }
    }
}
