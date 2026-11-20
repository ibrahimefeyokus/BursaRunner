using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI kosuText;
    public TextMeshProUGUI kestaneText;

    float mesafe = 0f;
    int kestane = 0;
    public float hiz = 12f;

    void Awake() { instance = this; }

    void Update()
    {
        if (PlayerController.isRunningNow)
        {
            mesafe += hiz * Time.deltaTime;
            // Timsah ikonu zaten solda Image olarak duruyor, sadece sayý + m
            if (kosuText) kosuText.text = $"<b>{Mathf.FloorToInt(mesafe)}</b> m";
        }

        // Kestane ikonu solda, sadece sayý
        if (kestaneText) kestaneText.text = $"<b>{kestane}</b>";
    }

    public void KestaneAl()
    {
        kestane++;
    }

    public void Sifirla()
    {
        mesafe = 0;
        kestane = 0;
    }
    public float CurrentDistance => mesafe;
}