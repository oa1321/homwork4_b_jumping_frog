using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaner : MonoBehaviour
{
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [SerializeField] float secondsBetweenSpawns = 1f;

    // OLD CODE using coroutines:
    //
    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
        Debug.Log("Start finished");
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, transform.position, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }

}
