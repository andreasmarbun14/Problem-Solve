using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class PengaturanSkors : MonoBehaviour
{
    #region singleton

    private static PengaturanSkors Input_Skor;

    public static PengaturanSkors Instance
    {
        get
        {
            if (Input_Skor == null)
                Input_Skor = FindObjectOfType<PengaturanSkors>();
            return Input_Skor;
        }
    }

    #endregion

    private static int Nilai_Windah;

    public Text Nilai_Ku;

    // Method Ketika Objek Trigger
    private void Awake()
    {
        Nilai_Windah = 0;
    }

    private void Update()
    {
        Nilai_Ku.text = "Nilai-Ku : " + Nilai_Windah;
    }

    public void SkorSings()
    {
        Nilai_Windah++;
    }

    // :D
    // Maafkeun Kalau Suka Sembarangan Isi Scriptnya, Soalnya Saya Trauma Di-Copas Kayak Chapter-2 :))
}
