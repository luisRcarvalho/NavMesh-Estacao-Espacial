using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    //criando a variavel publica do agent
    public NavMeshAgent agent;
    void Start()
    {
        //pegando o componente navmeshagent do gameobject e referenciando ele a nossa variavel agent
        agent = this.GetComponent<NavMeshAgent>();
    }

}
