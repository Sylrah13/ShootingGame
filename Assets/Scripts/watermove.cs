using UnityEngine;

public class watermove : MonoBehaviour
{
    //public float moveSpeed = 0.0f;
    public float scrollSpeedY = 0.0f; //스크롤 속도 값을 담을 변수
    public float scrollValue = 0.0f; //스크롤의 변화값 변수
    void Start()
    {
    }

    void Update()
    {
        scrollSpeedY = scrollSpeedY - scrollValue; //변수에 값이 감소되도록 하는 코드

        // 메테리얼에 적용된 텍스쳐의 위치를 변경해서 스크롤 기능
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0.0f, scrollSpeedY);
        //Renderer 컴퍼넌트 접근.메테리얼접근.메테리얼의 텍스쳐 위치를 변경
        
    }
}
