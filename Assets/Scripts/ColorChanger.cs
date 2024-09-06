using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private GameObject sphere;
    private void OnCollisionEnter(Collision collision)
    {
        sphere = collision.collider.gameObject;
        Color sphereColor = sphere.GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = sphereColor;

    }
}
