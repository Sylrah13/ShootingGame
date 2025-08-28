using UnityEngine;

public class emissilemove : MonoBehaviour
{
    public float moveSpeed = 0.0f;

    public Vector3 targetPlayer = Vector3.zero;
    void Start()
    {
        targetPlayer = GameObject.Find("Player").transform.position;
        transform.LookAt(targetPlayer);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Destroy(gameObject);
            
            //Destroy(other.gameObject); //나말고 부딪것 지워
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
