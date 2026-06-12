using UnityEngine;
public class ControlCámara : MonoBehaviour
{
    public GameObject Enfocado;
    public float VelocidadCamara = 12f;
    public float PPU = 200f;

    private Vector3 _posicionReal;

    void Start()
    {
        _posicionReal = transform.position;
    }

    void Update()
    {
        Seguimiento();
    }

    public void Seguimiento()
    {
        Vector3 dir = (Enfocado.transform.position - _posicionReal).normalized;
        dir.z = 0;
        _posicionReal += dir * VelocidadCamara * Time.deltaTime;

        Vector3 posSnap = _posicionReal;
        posSnap.x = Mathf.Round(posSnap.x * PPU) / PPU;
        posSnap.y = Mathf.Round(posSnap.y * PPU) / PPU;
        transform.position = posSnap;
    }
}
