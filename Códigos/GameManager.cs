using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Bola bola;

    public Text pontuacaoJogadortxt;

    public Text pontuacaoComputadortxt;
    private int pontuacaopessoa;
    private int pontuacaorobo;

public void PontuarPessoa()
{
    pontuacaopessoa++;
    this.pontuacaoJogadortxt.text = pontuacaopessoa.ToString();
    this.bola.ResetaBola1();  
}

public void PontuarRobo()
{
    pontuacaorobo++;
    this.pontuacaoComputadortxt.text = pontuacaorobo.ToString();
    this.bola.ResetaBola1();  
}
}
