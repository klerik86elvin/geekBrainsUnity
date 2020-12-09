using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class EnemySpawner : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {        
        Create();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Create()
    {
        Instantiate(obj, transform.position, Quaternion.identity);
    }
}
