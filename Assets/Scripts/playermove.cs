using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class playermove : MonoBehaviour
{
    //wasd 눌러서 앞뒤좌우 움직이게 하세요
    public float moveSpeed = 0.0f; //이동값을 담는 변수
    public float moveRL = 0.0f; // Input.GetAxis("Horizontal");값을 담을 변수
    public float moveFB = 0.0f; // Input.GetAxis("Vertical"); 값을 담을 변수
    void Start()
    {
        
    }

    void Update()
    {
        Keymove(); // Keymove(); 이름을 가진 함수 실행
        Limitmove(); //Limitmove(); 이름을 가진 함수 실행
    }

    void Keymove() //이동 기능
    {
        moveRL = Input.GetAxis("Horizontal"); //A키를 누르면 -1, D 키를 누르면 1의 값이 생성
        moveFB = Input.GetAxis("Vertical"); //S 키를 누르면 -1, W 키를 누르면 1의 값이 생성

        transform.Translate(Vector3.right * moveRL * moveSpeed * Time.deltaTime); //moveRL값에 따라 -1 이면 왼쪽, 0 이면 멈춤, 1이면 오른쪽 이동
        transform.Translate(Vector3.forward * moveFB * moveSpeed * Time.deltaTime); //moveFB값에 따라 -1 이면 뒤쪽, 0 이면 멈춤, 1이면 앞쪽 이동
    }

    void Limitmove() //화면 밖으로 못 나가게
    {

    }
}
