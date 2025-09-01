using UnityEngine;

public class missilepower : MonoBehaviour
{
    public GameObject missile1 = null;
    public GameObject missile2 = null;
    public GameObject missile3 = null;
    public GameObject missile4 = null;

    public int missilePower = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if (missilePower == 0)
            {
                Instantiate(missile1, transform.position, transform.rotation);
            }
            else if (missilePower == 1)
            {
                Instantiate(missile2, transform.position, transform.rotation);
            }
            else if (missilePower == 2)
            {
                Instantiate(missile3, transform.position, transform.rotation);
            }
            else if (missilePower == 3)
            {
                Instantiate(missile4, transform.position, transform.rotation);
            }
        }
    }
}
