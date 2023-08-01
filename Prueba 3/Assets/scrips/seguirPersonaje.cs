using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target; // Referencia al transform del personaje que el enemigo seguirá
    public float followSpeed = 2f; // Velocidad a la que el enemigo seguirá al personaje
    public float stoppingDistance = 2f; // Distancia a la que el enemigo se detendrá del personaje
    public float lookThreshold = 0.8f; // Umbral para determinar si el personaje está mirando al enemigo

    private void Update()
    {
        // Calcula la distancia entre el enemigo y el personaje
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        // Si la distancia es menor o igual a la distancia de parada, el enemigo se detiene
        if (distanceToTarget > stoppingDistance)
        {
            // Calcula la dirección hacia el personaje y el enemigo hacia adelante
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            Vector3 forwardDirection = transform.forward;

            // Calcula el producto punto entre las direcciones
            float dotProduct = Vector3.Dot(directionToTarget, forwardDirection);

            // Verifica si el personaje está mirando al enemigo y si el enemigo no está mirando al personaje
            if (dotProduct > lookThreshold)
            {
                // Invierte la dirección para que el enemigo también dé la vuelta
                directionToTarget = -directionToTarget;
            }

            // El enemigo sigue al personaje en la dirección calculada
            transform.position += directionToTarget * followSpeed * Time.deltaTime;
        }
    }
}
