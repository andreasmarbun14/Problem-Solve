using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackScenes : MonoBehaviour
{
    [SerializeField] private Button TombolKembali;

    private void Start()
    {
        TombolKembali.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(0);
        });
    }
}
