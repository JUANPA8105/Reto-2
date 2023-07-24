using UnityEngine;

public class PlataformaSaltar : MonoBehaviour
{
    public float fuerzaSalto = 5f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el objeto que colisionó tiene el tag "Player" (ajusta el tag según el tag de tu personaje)
        if (collision.gameObject.CompareTag("Player"))
        {
            // Obtener el componente Rigidbody2D del personaje
            Rigidbody2D rbPersonaje = collision.gameObject.GetComponent<Rigidbody2D>();

            if (rbPersonaje != null)
            {
                // Aplicar una fuerza hacia arriba para el salto del personaje
                rbPersonaje.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            }
        }
    }
}
