using UnityEngine;using TMPro;

public class VidaDoPersonagem : MonoBehaviour{
    public int vidaMaxima = 3;
    public int vidaAtual;


    public TMP_Text textoVida;


    public Transform pontoRespawn;

    public GameObject TelaMorte;
    

    public void AtualizarVidaUI()

    {

        AtualizarTexto();

    }


    void Start()
    {
        TelaMorte.gameObject.SetActive(false);
        vidaAtual = vidaMaxima;
        AtualizarTexto();
    }


    public void ReceberDano(int dano)
    {
        vidaAtual -= dano;


        if (vidaAtual <= 0)
        {
            vidaAtual = 0;
            TelaMorte.gameObject.SetActive(true);


            AtualizarTexto();
            Morrer();
            return;
        }


        AtualizarTexto();
    }


    void AtualizarTexto()
    {
        if (textoVida != null)
        {
            textoVida.text = "Vida: " + vidaAtual + "/" + vidaMaxima;
        }
    }


    void Morrer()
    {
        Debug.Log("Jogador morreu!");


        if (pontoRespawn != null)
        {
            CharacterController cc = GetComponent<CharacterController>();


            if (cc != null)
                cc.enabled = false;


            transform.position = pontoRespawn.position;


            if (cc != null)
                cc.enabled = true;
        }


        vidaAtual = vidaMaxima;
        AtualizarTexto();
    }
}