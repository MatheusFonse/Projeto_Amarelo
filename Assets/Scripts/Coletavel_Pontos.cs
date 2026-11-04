using UnityEngine;

public class Coletavel_Pontos : MonoBehaviour
{
    public int valor = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GerenciadorDoJogo.instancia.AdicionarPontos(valor);
            Destroy(gameObject);
        }

    }
}
