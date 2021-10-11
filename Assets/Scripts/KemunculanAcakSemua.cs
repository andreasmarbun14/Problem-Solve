using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KemunculanAcakSemua : MonoBehaviour
{
    //  Menambahkan Game Objek Kotak
    public GameObject kotak;
    public float Anjay_Kiri, Anjay_Kanan, Anjay_Bawah, Anjay_Atas;

    void Start()
    {
        // Setting Spawn Kotak
        StartCoroutine(Memunculkan_Kotak());
    }

    // Mengatur Letak Spawn Kotak
    IEnumerator Memunculkan_Kotak()
    {
        if (transform.childCount < 10)
        {
            float AcakX = Random.Range(Anjay_Kiri, Anjay_Kanan);
            float AcakY = Random.Range(Anjay_Bawah, Anjay_Atas);

            Instantiate(kotak, new Vector2(AcakX, AcakY), Quaternion.identity);

        }
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Memunculkan_Kotak());
    }
}   

// :D  // :))












































































    // Andreas Marbun :D
