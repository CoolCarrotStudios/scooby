using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private GameObject platformPrefab;
    private float levelSpeed = 4f;
    bool spawnable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(nameof(SpawnPlatformCoRoutine));
    }

    IEnumerator SpawnPlatformCoRoutine()
    {

        if (spawnable)
        {
            SpawnPlatform();
            spawnable = false;
        }
        else
        {
            yield return new WaitForSeconds(spawnInterval);
            spawnable = true;
        }


    }

    void SpawnPlatform()
    {
        GameObject platformInstance = Instantiate(platformPrefab, transform.position, Quaternion.identity);
        platformInstance.GetComponent<PlatformMove>().speed = levelSpeed; 
    }
}
