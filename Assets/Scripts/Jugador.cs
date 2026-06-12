using UnityEngine;
public class Jugador : MonoBehaviour
{
    public float VelocidadJugador = 5f;
    public float Vida = 100f;
    public float PPU = 200f;  // puedes cambiarlo desde el Inspector

    private Vector3 _posicionReal;

    void Start()
    {
        _posicionReal = transform.position;
    }

    void Update()
    {
        Movimiento();
    }

    public void Movimiento()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(x, y, 0).normalized;

        if (dir != Vector3.zero)
            _posicionReal += dir * VelocidadJugador * Time.deltaTime;

        Vector3 posSnap = _posicionReal;
        posSnap.x = Mathf.Round(posSnap.x * PPU) / PPU;
        posSnap.y = Mathf.Round(posSnap.y * PPU) / PPU;
        transform.position = posSnap;
    }
}
