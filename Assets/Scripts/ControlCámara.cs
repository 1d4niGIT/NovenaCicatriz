using UnityEngine;

public class ControlCámara : MonoBehaviour
{
    public GameObject Enfocado;
    public float VelocidadCamara = 20f;
    void Start()
    {
        
    }

    void Update()
    {
        Seguimiento();
    }
    
    public void Seguimiento()
    {
        /*// Seguir exactamente al jugador (sin suavizado)
        Vector3 pos = Enfocado.transform.position;
        pos.z = transform.position.z; // mantener Z de la cámara
        transform.position = pos;*/

        Vector3 dir = (Enfocado.transform.position - transform.position).normalized;
        dir.z = 0;
        transform.position += dir * VelocidadCamara * Time.deltaTime;
    }
    
}
