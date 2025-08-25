using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class missilespawner : MonoBehaviour
{
    public GameObject playerMissile;
    //�̻��� �߻� ������ ����
    //01 �ð� �Ἥ �Ͻø� �ǿ�. 0.5�� ���� �ѹ߾� �������� ����
    //02 �̻��� �߻� ���� 5���� ���� 5�� �� ����� �����ð� ���弼��
    //   ���� �ð��� 3�� �ּ��� 3�ʵڿ� 5�� ����..
    public float timeCheck = 0.0f; //�ð� �� ���� ����
    public float timeDelay = 0.0f; //������ �� ���� ����
    public int missileCount = 0; // �̻��� ���� ���� ����
    public int timerONOFF = 0; //Ÿ�̸� ����, ���� ���� ����

    void Start()
    {
        
    }

    void Update()
    {
        if (timerONOFF == 0)
        {
            MissileFire();
        }
        else if (timerONOFF == 1)
        {
            Timer();
        }
    }
    void MissileFire()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (missileCount > 0)
            {
                Instantiate(playerMissile, transform.position, transform.rotation);
                missileCount = missileCount - 1;
                timeDelay = 0.5f;
            }
            else if (missileCount == 0)
            {
                timeDelay = 3.0f;
                missileCount = 5;
            }
            timerONOFF = 1;
        }
    }
    void Timer()
    {
        timeCheck = timeCheck + Time.deltaTime;
        if (timeCheck > timeDelay)
        {
            timeCheck = 0.0f;
            timerONOFF = 0;
        }
    }
}
