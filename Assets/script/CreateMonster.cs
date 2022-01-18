using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMonster : MonoBehaviour
{
    public GameObject monster_prefab;
    public Transform[] posArray;
    int index = 0;
    float timeCd = 1;
    float TimeCd_ = 1;
    int totalNum = 3;
    int curNum = 0;
    bool makeMonster = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (curNum >= totalNum) return;
        {
            if (makeMonster)
            {
                timeCd -= Time.deltaTime;
                if (timeCd < 0)
                {
                    timeCd = TimeCd_;
                    doCreateMonster();
                }
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            makeMonster = true;
        }
    }

    void doCreateMonster()
    {
        Instantiate(monster_prefab, posArray[index++%posArray.Length].position,Quaternion.identity);
        ++curNum;
    }
}
