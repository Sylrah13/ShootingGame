using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class playermove : MonoBehaviour
{
    //wasd ������ �յ��¿� �����̰� �ϼ���
    public float moveSpeed = 0.0f; //�̵����� ��� ����
    public float moveRL = 0.0f; // Input.GetAxis("Horizontal");���� ���� ����
    public float moveFB = 0.0f; // Input.GetAxis("Vertical"); ���� ���� ����
    void Start()
    {
        
    }

    void Update()
    {
        Keymove(); // Keymove(); �̸��� ���� �Լ� ����
        Limitmove(); //Limitmove(); �̸��� ���� �Լ� ����
    }

    void Keymove() //�̵� ���
    {
        moveRL = Input.GetAxis("Horizontal"); //AŰ�� ������ -1, D Ű�� ������ 1�� ���� ����
        moveFB = Input.GetAxis("Vertical"); //S Ű�� ������ -1, W Ű�� ������ 1�� ���� ����

        transform.Translate(Vector3.right * moveRL * moveSpeed * Time.deltaTime); //moveRL���� ���� -1 �̸� ����, 0 �̸� ����, 1�̸� ������ �̵�
        transform.Translate(Vector3.forward * moveFB * moveSpeed * Time.deltaTime); //moveFB���� ���� -1 �̸� ����, 0 �̸� ����, 1�̸� ���� �̵�
    }

    void Limitmove() //ȭ�� ������ �� ������
    {

    }
}
