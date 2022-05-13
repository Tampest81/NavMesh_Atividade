using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Tank_Navmesh : MonoBehaviour
{
    [SerializeField] private NavMeshAgent[] capsuleNavAgents;

    private void FixedUpdate()
    {
        RaycastHit hitInfo;
        // Recebe a posi��o do click
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // Cria o raycast e retorna a informa��o
        Physics.Raycast(ray, out hitInfo);
        // Recebe o input do click
        if (Input.GetKey(KeyCode.Mouse0))
        {
            // Para cada NavMeshAgent ele ir� atribuir um ponto destino
            // Obs: O caminho mais r�pido ser� decidio pelo proprio navmesh
            // Obs2: Para fazer a diferencia��o do caminho � utilizado os AreaMask do proprio navmesh.
            foreach(NavMeshAgent navAgent in capsuleNavAgents)
            {
                navAgent.destination = hitInfo.point;
            }
        }

    }

}
