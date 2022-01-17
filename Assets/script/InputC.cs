using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputC : MonoBehaviour
{
    public Vector2 m_Movemnet;
    public bool m_atkTrigger;
    public Vector3 m_Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Movemnet.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        m_atkTrigger = Input.GetMouseButtonDown(0);
        m_Camera.Set(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse ScrollWheel"));
    }
}
