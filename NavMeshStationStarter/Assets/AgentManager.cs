using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    //array onde ficarão os agents
    GameObject[] agents;
    void Start()
    {
        //faz a busca por todos o agents na cena desde que estejam com a tag "ai"
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {
        //pega o clique esquerdo do mouse
        if (Input.GetMouseButtonDown(0))
        { 
            //criação do raycast hit
            RaycastHit hit;
            //o raycast pega pela camera aonde foi o clique do mouse
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) 
            {
                //e pega todos os agents dentro do array
               foreach(GameObject a in agents)
                {
                    //e manda ao destino definido pelo clique do mouse
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
                } 
            }
        }
    }
}
