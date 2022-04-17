using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject Pipes;


    public void Start()
    {
        StartCoroutine(Pipespawner());
    }

    IEnumerator Pipespawner()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-1f, 4f);
            GameObject newPipe =  Instantiate(Pipes, new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(newPipe, 10);
        }
    }
}
