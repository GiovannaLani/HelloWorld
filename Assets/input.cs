using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    public float speed;
    private float x;
    // Start is called before the first frame update
    void Start()
    {
        CreateCubeAndSetParent();

    }

    private void CreateCubeAndSetParent()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        CheckScale();
        Rotation();
    }

    private void CheckMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * speed ;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.position += Vector3.back * speed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += Vector3.forward * speed;
        }
    }

    private void CheckScale()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.transform.localScale += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            this.transform.localScale += Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            this.transform.localScale += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.transform.localScale += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            this.transform.localScale += Vector3.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            this.transform.localScale += Vector3.back * speed;
        }

    }

    private void Rotation()
    {
        x += Time.deltaTime * 30;
        this.transform.rotation = Quaternion.Euler(x, 0, 0);
    }
}
