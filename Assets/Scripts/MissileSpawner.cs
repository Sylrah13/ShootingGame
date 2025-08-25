using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class missilespawner : MonoBehaviour
{
    public GameObject playerMissile;
    //미사일 발사 딜레이 구현
    //01 시간 써서 하시면 되요. 0.5초 마다 한발씩 나가도록 구현
    //02 미사일 발사 갯수 5개를 만들어서 5발 다 쏘고나면 충전시간 만드세요
    //   충전 시간은 3초 주세요 3초뒤에 5발 충전..
    public float timeCheck = 0.0f; //시간 값 담을 변수
    public float timeDelay = 0.0f; //딜레이 값 담을 변수
    public int missileCount = 0; // 미사일 갯수 담을 변수
    public int timerONOFF = 0; //타이머 꺼짐, 실행 관리 변수

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
