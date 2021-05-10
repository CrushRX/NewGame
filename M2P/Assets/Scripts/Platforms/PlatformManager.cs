using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    private int randInt;
    public List<GameObject> platform;
    private Vector3[] lines = new[] {new Vector3(2,-4,11),
                             new Vector3(17,0,5),
                             new Vector3(19,0,10)};    // last 2 need?

    void Start()
    {
        StartCoroutine("SpawnPlatform");
    }

    IEnumerator SpawnPlatform()
    {
        while (true)
        {
            randInt = Random.Range(0, 3);
            Instantiate(platform[0], lines[0], platform[0].transform.rotation);
            yield return new WaitForSeconds(2.2f); // every 2.2 sec??? balance needed
        }
    }

}
