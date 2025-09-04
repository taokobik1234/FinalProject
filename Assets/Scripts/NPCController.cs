using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator animator;
    public GameObject path;
    public Transform[] pathPoints;
    public int index = 0;
    public float minDist = 1f; 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (agent == null) Debug.LogError("NavMeshAgent missing!");

        agent.autoBraking = false;

        animator = GetComponent<Animator>();
        if (animator == null) Debug.LogWarning("Animator missing!");

        // Populate path points
        if (path != null)
        {
            pathPoints = new Transform[path.transform.childCount];
            for (int i = 0; i < pathPoints.Length; i++)
            {
                pathPoints[i] = path.transform.GetChild(i);
            }

            if (pathPoints.Length == 0)
            {
                Debug.LogWarning("No path points under " + path.name);
            }
            else
            {

                agent.SetDestination(pathPoints[index].position);
            }
        }
        else
        {
            Debug.LogError("Path not assigned!");
        }
    }

    void Update()
    {
        if (pathPoints == null || pathPoints.Length == 0) return;

        roam();
        UpdateAnimation(); 
    }

    void roam()
    {
        
        if (Vector3.Distance(transform.position, pathPoints[index].position) < minDist)
        {
          
            index++;

        
            if (index >= pathPoints.Length)
            {
                index = 0;
            }

            // Đặt destination mới
            agent.SetDestination(pathPoints[index].position);

        }
    }

    void UpdateAnimation()
    {
        if (animator != null)
        {
            // Cập nhật animation based on speed
            float speed = agent.velocity.magnitude / agent.speed;
            animator.SetFloat("vertical", speed);
        }
    }
}