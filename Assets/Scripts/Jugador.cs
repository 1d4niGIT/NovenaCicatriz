using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float VelocidadJugador = 2f;
    public float Vida = 100f;
    void Start()
    {
        
    }

    void Update()
    {
        Movimiento();
    }
    public void Movimiento()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(x, y, 0);
        dir.Normalize();
        if (dir != Vector3.zero)
            transform.position += dir * VelocidadJugador * Time.deltaTime;
    }
}
