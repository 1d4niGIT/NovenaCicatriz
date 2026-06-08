using UnityEngine;

public class AtaqueRango : MonoBehaviour
{
    public float VelocidadProyectil = 5f;
    public float TiempoVivo = 3f;
    void Start()
    {
        Destroy(gameObject, TiempoVivo);
    }

    void Update()
    {
        transform.position += transform.up * VelocidadProyectil * Time.deltaTime;
    }
}
