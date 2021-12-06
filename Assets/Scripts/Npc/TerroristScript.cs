using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TerroristScript : MonoBehaviour
{

    public Transform endPosition;
    NavMeshAgent nav;
    FieldOfView fov;

    public float normalSpeed;
    public float shootingSpeed;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        fov = GetComponent<FieldOfView>();
        nav.SetDestination(endPosition.position);
    }
    
    void Update()
    {
        if(fov.canSeePlayer == true)
        {
            nav.speed = shootingSpeed;
        }
        else
        {
            nav.speed = normalSpeed;
        }
    }
}
