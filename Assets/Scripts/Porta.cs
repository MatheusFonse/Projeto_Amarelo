
using UnityEngine;

public class Porta : MonoBehaviour
{
    public Transform destino;

    private void OnTriggerEnter(Collider other)
    {
        CharacterController jogador =
            other.GetComponentInParent<CharacterController>();

        if (jogador != null &&
            jogador.CompareTag("Player"))
        {
            if (Inventario.instancia.TemItem("(Chave)"))
            {
                Inventario.instancia.RemoverItem("(Chave)");

                jogador.enabled = false;
                jogador.transform.position = destino.position;
                jogador.enabled = true;

                Debug.Log("Porta aberta!");
            }
            else
            {
                Debug.Log("Você precisa de uma chave!");
            }
        }
    }
}