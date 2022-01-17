using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    public InputC inputc;
    public CharacterController controller;
    public float walkSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 dir = transform.TransformDirection(new Vector3(inputc.m_Movemnet.x/2, 0, inputc.m_Movemnet.y)); //·½Ïò
        controller.Move(dir*walkSpeed*Time.deltaTime);
    }
}
