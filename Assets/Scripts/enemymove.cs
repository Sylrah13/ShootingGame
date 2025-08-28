using UnityEngine;

public class enemymove : MonoBehaviour
{
    //public Vector3 targetPOS = Vector3.zero;

    public float moveSpeed = 0.0f;
    public Vector3 targetPos = Vector3.zero;

    public float posX = 0.0f;
    public float posZ = 0.0f;

    public float rndX = 0.0f;
    public float rndZ = 0.0f;
    void Start()
    {
        //targetPOS = new Vector3(-40.0f, 0.0f, 90.0f);
        //moveSpeed = 10.0f;
        {
            RandomPOS();
        }
    }

    void Update()
    {
        //transform.position = Vector3.MoveTowards(이동물체의 좌표, 도착좌표, 이동속도);
        //transform.position = Vector3.MoveTowards(transform.position, targetPOS, moveSpeed * Time.deltaTime);
        //transform.LookAt(targetPOS);

        //targetPos = GameObject.Find("TargetSphere").transform.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        transform.LookAt(targetPos);
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