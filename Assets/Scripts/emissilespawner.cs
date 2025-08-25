using UnityEngine;

public class emissilespawner : MonoBehaviour
{
    public GameObject emissile;
    public float timeCheck = 0.0f;
    void Start()
    {
        
    }

    void Update()
    {
        timeCheck = timeCheck + Time.deltaTime;
        if(timeCheck >= 4.0f)
        {
            Instantiate(emissile, transform.position, transform.rotation);
            timeCheck = 0.0f;
        }
    }
}
