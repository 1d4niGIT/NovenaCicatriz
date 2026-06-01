using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float Speed;
    void Start()
    {
        
    }

    void Update()
    {
        Movimiento();
    }
    void Movimiento()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(x, y, 0);
        dir.Normalize();
        if (dir != Vector3.zero)
            transform.position += dir * Speed * Time.deltaTime;
    }
}
