﻿using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Follower : MonoBehaviour
{
    [SerializeField]
    private Transform m_Target = null;

    private NavMeshAgent m_Agent = null;

    private void Awake()
    {
        m_Agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        m_Agent.SetDestination(m_Target.transform.position);
    }

    public void SetTarget(Transform target)
    {
        m_Target = target;
    }
}