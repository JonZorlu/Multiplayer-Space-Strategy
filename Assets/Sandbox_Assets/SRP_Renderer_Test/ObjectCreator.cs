using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HamCorGames.Benchmark
{
    public class ObjectCreator : MonoBehaviour
    {
        [SerializeField] private GameObject prefabToSpawn = null;

        [SerializeField] private int totalObjectsToSpawn = 100;



        private void Start()
        {
            prefabToSpawn.transform.position = Vector3.zero;

            StartCoroutine(SpawnPrefabs());
        }

        private IEnumerator SpawnPrefabs()
        {
            for (int i = 0; i < totalObjectsToSpawn/5; i+=2)
            {
                for (int j = 0; j < totalObjectsToSpawn/5; j+=2)
                {
                    Instantiate(prefabToSpawn, new Vector3(i, j, 0), Quaternion.identity);
                    
                    yield return null;
                }
            }

        }



        


    }
}


