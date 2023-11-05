using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameManager Instance;
    public static int score;
    public Text scoretxt;
    public GameObject GameOverCanvas;
    public static bool hit;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        hit = false;
        GameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hit != true)
        {
            updatescore();
        }
        if (hit == true && GameOverCanvas.activeSelf != true)
        {
            Gameover();
        }
    }
    public static void AddScore(int ScoreToAdd)
    {
        score += ScoreToAdd;
    }
    public void Gameover()
    {
        GameOverCanvas.SetActive(true);
    }
    public void updatescore()
    {
        scoretxt.text = "Score: " + score.ToString();
    }
}
