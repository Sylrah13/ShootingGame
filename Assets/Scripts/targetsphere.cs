using UnityEngine;

public class targetsphere : MonoBehaviour
{
    public float spherePosX = 0.0f;
    public float spherePosZ = 0.0f;

    public float rndX = 0.0f;
    public float rndZ = 0.0f;

    public Vector3 enemyPos = Vector3.zero;
    void Start()
    {
        RandomMove();
    }
    void Update()
    {
        enemyPos = GameObject.Find("Enemy").transform.position;
        if(transform.position == enemyPos )
        {
            RandomMove();
        }
    }
    void RandomMove()
    {
        rndX = 50.0f;
        rndZ = 80.0f;

        spherePosX = Random.Range(-rndX, rndX);
        spherePosZ = Random.Range(-rndZ, rndZ);

        transform.position = new Vector3(spherePosX, transform.position.y, spherePosZ);
    }
}
