using UnityEngine;
using TMPro; // TextMeshPro

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text Player1ScoreText;
    [SerializeField] private TMP_Text CPUScoreText;

    [SerializeField] private Transform Player1Transform;
    [SerializeField] private Transform CPUTransform;
    [SerializeField] private Transform BallTransform;

    public int Player1Score;
    public int CPUScore;
    private static GameManager instance;
    /* Padrão de projeto criacional: Singleton */
    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public void Player1Scored()
    {
        Player1Score++;
        Player1ScoreText.text = Player1Score.ToString();
    }
    public void CPUScored()
    {
        CPUScore++;
        CPUScoreText.text = CPUScore.ToString();
    }
}