
   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FiniteStateMachine : MonoBehaviour
{
   
    Animator anim;
    // public GameObject player;
    public Transform target;
    NavMeshAgent agent;
    public static FiniteStateMachine instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        return;
    }
    public enum STATE
    {
        MOVE,
        ATTACK,
        DAMAGE,
        WIN
    }
    public STATE state = STATE.MOVE;
    // Start is called before the first frame update
   
    void Start()
    {

        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case STATE.MOVE:
                Move();
                break;
            case STATE.ATTACK:
                Attack();
                break;
            case STATE.DAMAGE:

                break;
            case STATE.WIN:
                break;
            default:
                break;
        }
    }

    public void Move()
    {
        // anim.SetBool("Run", true);
        anim.SetBool("Attack", false);
        agent.stoppingDistance = 10f;

        if (Vector3.Distance(target.position, this.transform.position) <= 20f)
        {
            state = STATE.ATTACK;
        }

    }

    public void Attack()
    {
        // anim.SetBool("Run", false);
        anim.SetBool("Attack", true);
        anim.SetBool("Death", false);
        if (Vector3.Distance(target.position, this.transform.position) >= 10f)
        {
            state = STATE.MOVE;
        }




        Debug.Log("Attack");
    }

    public void Damage()
    {
        anim.SetBool("Attack", false);
        anim.SetBool("Death", true);
        Debug.Log("Dead");
    }
    public void Win()
    {

    }


}
