using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnic : MonoBehaviour
{
    public Animator ani;
    public InputC inputc;
    float 连击数重置time = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ani.SetFloat("aniTime", Mathf.Repeat(ani.GetCurrentAnimatorStateInfo(0).normalizedTime,1) );
        if (inputc.m_atkTrigger)
        {
            连击数重置time = 2;
            ani.SetInteger("连击数", (ani.GetInteger("连击数")+1)%3);
            ani.SetTrigger("atk");
        }
        ani.SetFloat("水平速度", inputc.m_Movemnet.x);
        ani.SetFloat("垂直速度", inputc.m_Movemnet.y);

        连击数重置time -= Time.deltaTime;
        if (连击数重置time < 0)
        {
            连击数重置time = 2;
            ani.SetInteger("连击数", 0);
        }
    }

    private void LateUpdate()
    {
        ani.ResetTrigger("atk");
    }
}
