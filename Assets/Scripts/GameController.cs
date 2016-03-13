using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class GameController : MonoBehaviour
{
    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;


  



    // PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;

        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                //this._endGame();
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValue;
            }
        }
    }





    //PUBLIC INSTANCE VARIABLES
    
    public Text LivesLabel;
    public Text ScoreLabel;
    
    public Text GameOverLabel;
    public HeroController player;
    
    public Text HighScoreLabel;
    public Button RestartButton;

    // Use this for initialization
    void Start()
    {

        this._initialize();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //private methods=========================



    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 5;


       
        this.HighScoreLabel.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive(false);
        this.GameOverLabel.gameObject.SetActive(false);




    }


    private void _endGame()
    {
        this.GameOverLabel.gameObject.SetActive(true);
        this.player.gameObject.SetActive(false);
        
        this.LivesLabel.gameObject.SetActive(false);
        this.ScoreLabel.gameObject.SetActive(false);
        this.HighScoreLabel.gameObject.SetActive(true);
        this.HighScoreLabel.text = "High Score: " + this._scoreValue;
       
        this.RestartButton.gameObject.SetActive(true);
    }





    // PUBLIC METHODS

    public void RestartButtonClick()
    {
        Application.LoadLevel(0);
    }
}