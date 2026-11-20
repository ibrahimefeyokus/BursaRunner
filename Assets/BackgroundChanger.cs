using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    public Sprite[] backgrounds;
    public float metersPerChange = 150f;
    private SpriteRenderer sr;
    private ScoreManager score;
    private int currentIndex = -1;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        score = FindFirstObjectByType<ScoreManager>();
        UpdateBackground(0);
    }

    void Update()
    {
        if (score == null) return;
        int index = Mathf.FloorToInt(score.CurrentDistance / metersPerChange) % backgrounds.Length;
        if (index != currentIndex) UpdateBackground(index);
    }

    void UpdateBackground(int index)
    {
        currentIndex = index;
        sr.sprite = backgrounds[index];
    }
}