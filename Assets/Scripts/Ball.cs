using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float MaxForce;
    public float MinForce;
    public float speedRotation;
    private Rigidbody2D rg;
    private LineRenderer lineRenderer;
    
    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default")); // Un ejemplo de shader
        lineRenderer.startColor = Color.black;
        lineRenderer.endColor = Color.black;
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.velocity = transform.up * MaxForce;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            rg.velocity = transform.up * MinForce;
        }
        
        
        Vector3 spriteUp = transform.up;
        Vector3 lineStart = transform.position;
        Vector3 lineEnd = lineStart + spriteUp; // Ajusta la longitud según necesites

        lineRenderer.SetPosition(0, lineStart);
        lineRenderer.SetPosition(1, lineEnd);


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(transform.forward, speedRotation*Time.deltaTime);
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(transform.forward, -speedRotation*Time.deltaTime);
        }
    }
}
