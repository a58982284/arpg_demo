using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnic : MonoBehaviour
{
    public Animator ani;
    public InputC inputc;
    float ����������time = 2;
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
            ����������time = 2;
            ani.SetInteger("������", (ani.GetInteger("������")+1)%3);
            ani.SetTrigger("atk");
        }
        ani.SetFloat("ˮƽ�ٶ�", inputc.m_Movemnet.x);
        ani.SetFloat("��ֱ�ٶ�", inputc.m_Movemnet.y);

        ����������time -= Time.deltaTime;
        if (����������time < 0)
        {
            ����������time = 2;
            ani.SetInteger("������", 0);
        }
    }

    private void LateUpdate()
    {
        ani.ResetTrigger("atk");
    }
}
