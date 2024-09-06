using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreator : MonoBehaviour
{
    public int numberOfSpheres;
    public GameObject spherePrefab;
    void Start()
    {
        for (int i = 0; i< numberOfSpheres; i++)
        {
            CreateSphere();
        }
    }

    void CreateSphere() {
        var duplicateSphere = Instantiate(spherePrefab);
        duplicateSphere.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
        var color = Random.Range(0, 4);
        if (color == 0) {
            duplicateSphere.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (color == 1) {
            duplicateSphere.GetComponent<Renderer>().material.color = Color.green;
        }
        else {
            duplicateSphere.GetComponent<Renderer>().material.color = Color.blue;
        }

    }
}
