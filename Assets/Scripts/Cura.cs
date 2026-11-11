using UnityEngine;

public class Cura : MonoBehaviour
{
    public int quantidadeDeCura = 30;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VidaDoPersonagem vida = other.GetComponent<VidaDoPersonagem>();


            if (vida != null)
            {
                vida.vidaAtual += quantidadeDeCura;


                if (vida.vidaAtual > vida.vidaMaxima)
                {
                    vida.vidaAtual = vida.vidaMaxima;
                }


                vida.AtualizarVidaUI();


                Destroy(gameObject);
            }
        }
    }
}