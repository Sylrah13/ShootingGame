using UnityEngine;

public class PowerUpItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<MissilePower>().PowerUp();
            Destroy(gameObject); // æ∆¿Ã≈€ ∏‘¿∏∏È ªÁ∂Û¡¸
        }
    }
}
