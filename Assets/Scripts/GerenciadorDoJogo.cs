using TMPro;
using UnityEngine;

public class GerenciadorDoJogo : MonoBehaviour
{
    public static GerenciadorDoJogo instancia;
    public TextMeshProUGUI textoPontuacao;
    private int pontuacao = 0;
    
    void Awake()
    {
        instancia = this;

    }
    void Start()
    {
        AtualizarTexto();
    }
    public void AdicionarPontos(int quantidade)
    {
        pontuacao += quantidade;
        AtualizarTexto();
    }
    void AtualizarTexto()
    {
        textoPontuacao.text = "O valor de Dinheiro Coletado: " + pontuacao;
    }
}
