using UnityEngine;

public class MissilePower : MonoBehaviour
{
    [Header("미사일 단계별 프리팹 (1~4)")]
    public GameObject[] missilePrefabs;  // 0=1단계, 1=2단계, 2=3단계, 3=4단계

    [Header("발사 위치")]
    public Transform firePoint;

    [Header("발사 속도")]
    public float fireRate = 0.25f;

    private int powerLevel = 0; // 현재 미사일 단계 (0~3)
    private float lastFireTime;

    void Update()
    {
        // 스페이스바 발사
        if (Input.GetKey(KeyCode.Space) && Time.time > lastFireTime + fireRate)
        {
            FireMissile();
            lastFireTime = Time.time;
        }
    }

    void FireMissile()
    {
        GameObject prefab = missilePrefabs[powerLevel];

        switch (powerLevel)
        {
            case 0: // 1발
                Instantiate(prefab, firePoint.position, firePoint.rotation);
                break;

            case 1: // 2발
                Instantiate(prefab, firePoint.position + transform.right * -0.3f, firePoint.rotation);
                Instantiate(prefab, firePoint.position + transform.right * 0.3f, firePoint.rotation);
                break;

            case 2: // 4발 직선
                Instantiate(prefab, firePoint.position + transform.right * -0.4f, firePoint.rotation);
                Instantiate(prefab, firePoint.position + transform.right * -0.2f, firePoint.rotation);
                Instantiate(prefab, firePoint.position + transform.right * 0.2f, firePoint.rotation);
                Instantiate(prefab, firePoint.position + transform.right * 0.4f, firePoint.rotation);
                break;

            case 3: // 4발 부채꼴
                Instantiate(prefab, firePoint.position, firePoint.rotation * Quaternion.Euler(0, -15f, 0));
                Instantiate(prefab, firePoint.position, firePoint.rotation * Quaternion.Euler(0, -5f, 0));
                Instantiate(prefab, firePoint.position, firePoint.rotation * Quaternion.Euler(0, 5f, 0));
                Instantiate(prefab, firePoint.position, firePoint.rotation * Quaternion.Euler(0, 15f, 0));
                break;
        }
    }

    public void PowerUp()
    {
        // 배열 범위 안에서만 증가
        powerLevel = Mathf.Min(powerLevel + 1, missilePrefabs.Length - 1);
        Debug.Log("미사일 파워업! 현재 단계: " + (powerLevel + 1));
    }

}
