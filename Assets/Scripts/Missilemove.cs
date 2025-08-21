using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // 항상 월드 기준으로 앞으로 이동
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
    }
}
