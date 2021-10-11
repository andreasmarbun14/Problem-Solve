using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class BallWASDControl : MonoBehaviour
{
    private ContactPoint2D lastContactPoint;

    public KeyCode Ke_Atas = KeyCode.W;
    public KeyCode Ke_Bawah = KeyCode.S;
    public KeyCode Ke_Kiri = KeyCode.A;
    public KeyCode Ke_Kanan = KeyCode.D;
    public float speed = 10.0f;
    public float yBoundary = 10.0f;

    private Rigidbody2D rigidBody2D;

    void Start()
    {
        // Mengambil Komponen Method Rigibody
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Menambahkan Perubahan Posisi Setelah Menerima Input
        Vector2 velocity = rigidBody2D.velocity;

        // Method Input Ketika Menekan W
        if (Input.GetKey(Ke_Atas))
        {
            velocity.y = speed;
        }

        // Method Input Ketika Menekan A
        else if (Input.GetKey(Ke_Kiri))
        {
            velocity.x = -speed;
        }

        // Method Input Ketika Menekan S
        else if (Input.GetKey(Ke_Bawah))
        {
            velocity.y = -speed;
        }

        // Method Input Ketika Menekan D
        else if (Input.GetKey(Ke_Kanan))
        {
            velocity.x = speed;
        }

        // Jika Tidak Ada Input Sama Sekali Maka Tidak Akan Merubah Posisi Tersebut
        else
        {
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }

        // Method Mendapatkan Perubahan Posisi Setelah Menekan Tombol
        rigidBody2D.velocity = velocity;
        Vector3 position = transform.position;
        if (position.y > yBoundary)
        {
            position.y = yBoundary;
        }
        else if (position.y < -yBoundary)
        {
            position.y = -yBoundary;
        }
        transform.position = position;
    }

    // Andreas Marbun 
    // :D
}
