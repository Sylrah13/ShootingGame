using UnityEngine;

public class emissilemove : MonoBehaviour
{
    public float moveSpeed = 0.0f;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.Self);
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
