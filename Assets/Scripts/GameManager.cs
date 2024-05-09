using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
        public Text scoreView;
        private int _score;

        public int Score
}
    get => _score;
    set
    {

    _score = value;
    scoreView.text = value.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 0;
    }
    
