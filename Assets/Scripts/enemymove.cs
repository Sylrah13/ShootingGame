using UnityEngine;

public class enemymove : MonoBehaviour
{
    public Vector3 targetPOS = Vector3.zero;
    public float moveSpeed = 0.0f;
    void Start()
    {
        targetPOS = new Vector3(-40.0f, 0.0f, 90.0f);
        moveSpeed = 10.0f;
    }

    void Update()
    {
        //transform.position = Vector3.MoveTowards(이동물체의 좌표, 도착좌표, 이동속도);
        transform.position = Vector3.MoveTowards(transform.position, targetPOS, moveSpeed * Time.deltaTime);
        transform.LookAt(targetPOS);
    }
}
