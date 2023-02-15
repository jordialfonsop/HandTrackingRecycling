using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    private int ScoreP1 = 0;
    private int ScoreP2 = 0;

    [SerializeField]
    protected TMP_Text ScoreP1Text;
    [SerializeField]
    protected TMP_Text ScoreP2Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(int player, int score){
        if (player == 1){
            ScoreP1 += score;
            ScoreP1Text.text = ScoreP1.ToString();
        }else if(player == 2){
            ScoreP2 += score;
            ScoreP2Text.text = ScoreP2.ToString();
        }

    }
}
