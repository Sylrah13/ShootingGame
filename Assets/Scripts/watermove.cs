using UnityEngine;

public class watermove : MonoBehaviour
{
    //public float moveSpeed = 0.0f;
    public float scrollSpeedY = 0.0f; //��ũ�� �ӵ� ���� ���� ����
    public float scrollValue = 0.0f; //��ũ���� ��ȭ�� ����
    void Start()
    {
    }

    void Update()
    {
        scrollSpeedY = scrollSpeedY - scrollValue; //������ ���� ���ҵǵ��� �ϴ� �ڵ�

        // ���׸��� ����� �ؽ����� ��ġ�� �����ؼ� ��ũ�� ���
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0.0f, scrollSpeedY);
        //Renderer ���۳�Ʈ ����.���׸�������.���׸����� �ؽ��� ��ġ�� ����
        
    }
}
