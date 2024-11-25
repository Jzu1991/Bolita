using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCubo : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 offset;
    public Transform objetivo;

    void Start()
    {
        offset = transform.position - objetivo.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objetivo.position + offset;
    }
}
