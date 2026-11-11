using UnityEngine;

public class DanoDoMonstro : MonoBehaviour
{
    public int dano = 1;
    public float intervaloAtaque = 1f;


    private float proximoAtaque = 0f;


    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Time.time >= proximoAtaque)
            {
                VidaDoPersonagem vida = collision.gameObject.GetComponent<VidaDoPersonagem>();


                if (vida != null)
                {
                    vida.ReceberDano(dano);


                    proximoAtaque = Time.time + intervaloAtaque;
                }
            }
        }
    }
}