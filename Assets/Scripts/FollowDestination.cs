using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDestination : MonoBehaviour
{
    // Start is called before the first frame update
    private UnityEngine.AI.NavMeshAgent theAgent = null;
    public Transform destination = null;
    //void Start(){}

    void Awake()
    {
        theAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        theAgent.SetDestination(destination.position);
    }
}
