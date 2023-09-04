using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Main;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed=1;

    private void OnEnable()
    {
        SignalBus.Subscribe<float, float>("Move", Move);
    }
    private void OnDisable()
    {
        SignalBus.Unsubscribe<float, float>("Move", Move);
    }



    private void Move(float x, float y)
    {
        transform.position += new Vector3(x,0,y) * speed*Time.deltaTime;
    }
}
