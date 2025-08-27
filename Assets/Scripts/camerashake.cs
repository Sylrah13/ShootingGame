using UnityEngine;

public class camerashake : MonoBehaviour
{
    public GameObject mainCamera = null;
    public float shakeTime = 0.0f;
    public float ramdomPosX = 0.0f;
    public float ramdomPosZ = 0.0f;

    public int shakeONOFF = 0; // 0ÀÌ¸é Ä«¸Þ¶ó ¾È Èçµê, 1 ÀÌ¸é Ä«¸Þ¶ó Èçµê
    void Start()
    {
        
    }

    void Update()
    {
        if(shakeONOFF == 1)
        {
            ramdomPosX = Random.Range(-0.5f, 0.5f);
            ramdomPosZ = Random.Range(-0.5f, 0.5f);

            mainCamera.transform.position = new Vector3(ramdomPosX, mainCamera.transform.position.y, ramdomPosZ);

            shakeTime = shakeTime + Time.deltaTime;
            if (shakeTime > 0.5f)
            {
                mainCamera.transform.position = new Vector3(0.0f, mainCamera.transform.position.y, 0.0f);
                shakeONOFF = 0;
                shakeTime = 0.0f;
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        shakeONOFF = 1;
        //mainCamera.transform.position = new Vector3(1.0f, 2.0f, 3.0f);
    }
}
