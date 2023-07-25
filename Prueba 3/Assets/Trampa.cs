using UnityEngine;

public class Trampa : MonoBehaviour
{
    public bool activada = false;

    public void ActivarTrampa()
    {
        activada = true;
    }

    public void DesactivarTrampa()
    {
        activada = false;
    }
}
