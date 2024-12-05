using UnityEngine;

public class Barra : MonoBehaviour
{
 public float velocidade = 10.0f; //velocidade da barra, publico para poder editar no Unity
 
 protected Rigidbody2D rb; //variável que armazena o componente Rigidbody2D

 private void Awake() //função que é chamada para incializar o objeto
 {
     rb = GetComponent<Rigidbody2D>();
 }
}
