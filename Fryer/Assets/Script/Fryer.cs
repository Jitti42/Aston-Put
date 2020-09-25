using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Ui;

public class Fryer : MonoBehaviour
{
    public Transform F;
    public float delay;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",1,delay);
    }

    void Spawn()
    {
        Vector3 position = F.position;
        position.y = Random.Range(minY, maxY);
        position.x = 5f;
        GameObject.Instantiate(F, position, Quaternion.identity);
    }
}
