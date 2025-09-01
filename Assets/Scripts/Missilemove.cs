using UnityEngine;

public class missilemove : MonoBehaviour
{
    public float moveSpeed = 0.0f;
    public int moveState = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (moveState == 0)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        }
        else if (moveState == 1)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.Self);
        }
    }
}
