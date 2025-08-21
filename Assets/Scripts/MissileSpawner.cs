using UnityEngine;

public class MissileSpawner : MonoBehaviour
{
    public GameObject playerMissile;
    public float moveSpeed = 0.0f;
    //�̻��� �߻� ������ ����
    //01 �ð��Ἥ �Ͻø� �ǿ�. 0.5�� ���� �ѹ��� �������� ����
    //02 �̻��� �߻� ���� 5���� ���� 5�� �� ����� �����ð� ���弼��
    // ���� �ð��� 3�� �ּ���. 3�� �ڿ� 5�� ����.
    public float timeCheck = 0.0f; //�ð� �� ���� ����
    public float timeDelay = 0.0f; //������ �� ���� ����
    public int missileCount = 0; //�̻��� ���� ���� ����
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        Instantiate(playerMissile, transform.position, transform.rotation);
    }
}