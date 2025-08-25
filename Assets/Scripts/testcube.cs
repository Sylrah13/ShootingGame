using UnityEngine;

public class testcube : MonoBehaviour
{
    //public GameObject testSphereA;
    //public Transform testSphereB;
    public Vector3 testSphereC;
    void Start()
    {
        //Debug.Log(testSphereA.transform.position);
        //testSphereA.transform.position = new Vector3(-3.0f, -4.0f, -5.0f);

        //testSphereB.transform.position = new Vector3(-1.0f, -2.0f, -3.0f);
        //testSphereB.position = new Vector3(-1.0f, -2.0f, -3.0f);

        testSphereC = GameObject.Find("Sphere").transform.position;

    }

    void Update()
    {
        
    }
}
