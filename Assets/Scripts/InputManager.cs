using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Main;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private float horizontal = 0, vertical = 0;
    

    // Update is called once per frame
    void Update()
    {
        horizontal = 0;
        vertical = 0;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            vertical += 1f;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            vertical -= 1f;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal -= 1f;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            horizontal += 1f;
        }

        SignalBus.BroadcastSignal<float, float>("Move", horizontal, vertical);
    }
}
