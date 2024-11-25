using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cubo : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidadMovimiento = 5f;
    public float fuerzaSalto = 10f;
    private Rigidbody rb;
    private int puntuacion = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Movimiento horizontal (WASD)
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical) * velocidadMovimiento * Time.deltaTime;
        rb.MovePosition(transform.position + movimiento);

        // Salto (barra espaciadora)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            SceneManager.LoadScene("Derrota");
        } else if (collision.gameObject.CompareTag("Win"))
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
