using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSM : StateMachine
{
    private State _currentState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnterChair()
    {
        StartCoroutine(_currentState.OnChair());
    }

    public void OnExitChair()
    {
        StartCoroutine(_currentState.GameOver());
    }
}
