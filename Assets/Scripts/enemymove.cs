using UnityEngine;

public class enemymove : MonoBehaviour
{
    public float moveSpeed = 0.0f;
    public Vector3 targetPos = Vector3.zero;

    public float posX = 0.0f;
    public float posZ = 0.0f;

    public float rndX = 0.0f;
    public float rndZ = 0.0f;
    void Start()
    {
        RandomPOS();
    }
    void Update()
    {
        //targetPos = GameObject.Find("TargetSphere").transform.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        transform.LookAt(targetPos);
        if(transform.position == targetPos)
        {
            RandomPOS();
        }
    }
    void RandomPOS()
    {
        rndX = 50.0f;
        rndZ = 90.0f;

        posX = Random.Range(-rndX, rndX);
        posZ = Random.Range(-rndZ, rndZ);

        targetPos = new Vector3(posX, transform.position.y, posZ);
    }
}
