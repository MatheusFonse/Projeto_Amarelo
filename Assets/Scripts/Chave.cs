using UnityEngine;

public class Chave : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Inventario.instancia.AdicionarItem("(Chave)");

            Destroy(gameObject);
        }
    }
}