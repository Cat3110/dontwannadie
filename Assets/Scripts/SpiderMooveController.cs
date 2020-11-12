using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace DontWannaDie
{
    public class SpiderMooveController : MonoBehaviour
    {
        #region Field

        private NavMeshAgent _agent;
        public GameObject destinationObject;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
            _agent.destination = destinationObject.transform.position;
        }

        private void Update()
        {
            if (_agent.remainingDistance < _agent.stoppingDistance)
            {
                destinationObject = destinationObject.GetComponent<WaypointController>().nextWaypoint;
                _agent.SetDestination(destinationObject.transform.position);
            }
        }

        #endregion
    }
}

