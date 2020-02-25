using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnApple : MonoBehaviour
{

    public GameObject apple;
    public void ho()
    {
        Vector3 position = new Vector3(Random.Range(-5.36f, 4.99f), 3.5f, 0);
        Instantiate(apple, position, Quaternion.identity);
    }
}
