using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterC : Attribute
{
    protected float hp = 0;     //ʣ��HP
    protected Animator ani;
    protected CharacterController cc;
    protected float ����cd_;
    protected float Ӳֱʱ��_;
    protected float ����ʱ��_;
    protected float ǰҡʱ��_;
    protected float ��ҡʱ��_;
    public ����״̬ ״̬;
    protected Transform Ŀ��;
    protected Transform player;

    Vector3[] Ѳ�ߵ�array = new Vector3[2];
    int Ѳ�ߵ�Ŀ��index = 0;


    public enum ����״̬
    {
        û��Ŀ��,
        ����Ŀ��,
        ����,
        ����,
        ׷��,
        ��������,
        ����ǰҡ,
        ������,
        ������ʼ,
        ������ҡ,
        Ӳֱ,
    }
    private void Awake()
    {
        binding();
    }

    void binding()
    {
        cc = this.GetComponent<CharacterController>();
        ani = this.transform.GetChild(0).GetComponent<Animator>();
        hp = hpmax;
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 ������pos = this.transform.position;
        Ѳ�ߵ�array[0] = ������pos + new Vector3(Random.Range(1, 3), 0, Random.Range(1, 3));
        Ѳ�ߵ�array[1] = ������pos + new Vector3(Random.Range(-1, -3), 0, Random.Range(-1, -3));
    }

    // Update is called once per frame
    void Update()
    {
        if (״̬ == ����״̬.û��Ŀ��)
        {
            ���Է���Ŀ��();
        } else if (״̬ == ����״̬.����Ŀ��)
        {
            ���Ŀ�����();
        }else if (״̬ ==����״̬.׷��)
        {
            ����׷��();
        }
        else if (״̬ == ����״̬.��������)
        {
            ��Թ�������();
        }
        else if (״̬ == ����״̬.������ʼ)
        {
            ��������();
        }
        else if (״̬ == ����״̬.����ǰҡ)
        {
            ǰҡ();
        }
        else if (״̬ == ����״̬.������ҡ)
        {
            ��ҡ();
        }
        else if (״̬ == ����״̬.����)
        {
            ����();
        }
    }

    void ���Է���Ŀ��()
    {
        if (player ==null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        Ѳ��();
        float distance = Vector3.Distance(this.transform.position, player.position);
        if (distance<=������Χ)
        {
            ����Ŀ��();
        } else if (distance<=�Ӿ���Χ&&ToolMethod.��ȡ��Ŀ��ļн�(player.position,this.transform)<60)
        {
            ����Ŀ��();
        }
        else
        {
            ���Ŀ��();
        }
    }
    void ���Ŀ�����()
    {
        int R = Random.Range(0, 100);
        if (R<=׷������)
        {
            ״̬ = ����״̬.׷��;
        }
        else
        {
            ״̬ = ����״̬.����;
        }
    }
    void ����Ŀ��()
    {
        ״̬ = ����״̬.����Ŀ��;
        Ŀ�� = player;
    }
    void ���Ŀ��()
    {
        ״̬ = ����״̬.û��Ŀ��;
        Ŀ�� = null;
    }
    void ����׷��()
    {
        if (����Ƿ�ɹ���())
        {
            ״̬ = ����״̬.��������;
            return;
        }
        if (����Ƿ�ʧȥĿ��())
        {
            ״̬ = ����״̬.û��Ŀ��;
            return;
        }
        Vector3 pos = Ŀ��.position;
        pos.y = this.transform.position.y;
        this.transform.LookAt(pos);
        cc.Move(this.transform.forward*moveSpeed*Time.deltaTime);

    }
    bool ����Ƿ�ɹ���()
    {
        return false;
    }
    bool ����Ƿ�ʧȥĿ��()
    {
        return false;
    }
    void ��Թ�������()
    {

    }
    void ��������()
    {

    }
    void ǰҡ()
    {

    }
    void ��ҡ()
    {

    }
    void ����()
    {

    }
    void Ѳ��()
    {
        this.transform.LookAt(Ѳ�ߵ�array[Ѳ�ߵ�Ŀ��index]);
        cc.Move(this.transform.forward * moveSpeed * Time.deltaTime);
        if (Vector3.Distance(this.transform.position,Ѳ�ߵ�array[Ѳ�ߵ�Ŀ��index])<0.1f)
        {
            Ѳ�ߵ�Ŀ��index = ++Ѳ�ߵ�Ŀ��index % Ѳ�ߵ�array.Length;
        }
    }
}
