using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float viewDistance = 10;
    public Transform target;
    public float speed = 1;
    public int wanderChance = 100;
    public float wanderDistance = 5;
    public Animator animator;

    Rigidbody rb;
    NavMeshAgent agent;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        animator.Play("Idle");
    }

    void Update()
    {
        if(target == null)return;

        agent.speed = speed;

        var distance = Vector3.Distance(transform.position, target.position);

        if (distance < viewDistance)
        {
            // SEEK
            agent.destination = target.position;
        }
        else if (Random.Range(0, wanderChance) == 1)
        {
            var offset = Random.insideUnitSphere * wanderDistance;
            agent.destination = transform.position + offset;
        }


        // ANIMATION
        if (agent.velocity == Vector3.zero)
        {
            animator.Play("Idle");
        }
        else
        {
            animator.Play("Run");
        }

        if (distance < 1f)
        {
            // JUMPSCARE
        }
    }
}