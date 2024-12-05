using UnityEngine;

public class Bola : MonoBehaviour
{

private Rigidbody2D rb; //variável que armazena o componente Rigidbody2D

 private void Awake() //função que é chamada para incializar o objeto
 {
     rb = GetComponent<Rigidbody2D>();
 }

 public float velocidade = 100.0f; //velocidade da bola, "publico" para poder editar no Unity
private void Start()
{
    ResetaBola1();
}

public void ResetaBola1(){
    rb.position = Vector2.zero;
    rb.velocity = Vector2.zero;

    ForcaInicial();
}

private void ForcaInicial()
{
    float X = Random.value < 0.5f ? -1 : 1; // se o valor aleatório for menor que 0.5, A bola se mexe para a esquerda, senão vai para a direita
    float Y = Random.value < 0.5f ? Random.Range(-0.5f, -1f) : Random.Range(0.5f, 1f); // se o valor aleatório for menor que 0.5, a bola se move para baixo, senão vai para cima

    Vector2 forca = new Vector2(X, Y);
    rb.AddForce(forca * velocidade);
} 


public void AddForce (Vector2 forca)
{
    rb.AddForce(forca);

} 

}

