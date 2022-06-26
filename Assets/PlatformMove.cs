using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Later swap out speed for LevelSpeed and get from game manager
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
