using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Memunculkan : MonoBehaviour
{
    public GameObject Kotak_Kubus_Ku;
    public float Anjay_Kiri, Anjay_Kanan, Ohh_Atas, Ohh_Bawah;

    void Start()
    {
        Lah_Kok_TibaTibaAda();
    }
    void Lah_Kok_TibaTibaAda()
    {
        int Mau_BerapaBanyakYa = Random.Range(15, 30);
        for (int i = 0; i < Mau_BerapaBanyakYa; i++)
        {
            float randomX = Random.Range(Anjay_Kiri, Anjay_Kanan);
            float randomY = Random.Range(Ohh_Atas, Ohh_Bawah);
            Instantiate(Kotak_Kubus_Ku, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
