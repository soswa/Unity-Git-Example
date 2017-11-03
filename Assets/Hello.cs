using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Debug.Log("Hello");
    }

    private void Update()
    {
        transform.Rotate(0f, 30f * Time.deltaTime, 0f);
    }
}