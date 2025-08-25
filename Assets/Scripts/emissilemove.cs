using UnityEngine;

public class emissilemove : MonoBehaviour
{
    public float moveSpeed = 0.0f;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
    }
}
