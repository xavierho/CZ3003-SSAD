using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
    public class Spawn : MonoBehaviour
    {
        public float maxtiming;
        private float timing;
        public GameObject Ghost;
        private GameObject ghost;
        public Transform knight;
        // Start is called before the first frame update
        void Start()
        {
            timing = maxtiming;
        }

        // Update is called once per frame
        void Update()
        {
            timing -= Time.smoothDeltaTime;
            if (timing < 0)
            {
                ghost = Instantiate(Ghost, new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), transform.rotation);
                ghost.GetComponent<AIDestinationSetter>().target = knight;
                timing = maxtiming;
                GameObject game = GameObject.Find("Main Camera");
                game.GetComponent<ChangeScene>().numOfEnemies++;
            }
        }
    }
}
