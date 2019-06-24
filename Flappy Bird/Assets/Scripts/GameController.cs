using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public bool isEndGame=false;
    int gamePoint = 100;
    public Text txtPoint;
    public GameObject pnlEndGame;
    public Text txtEndPoint;
    public Button butRestart;
    bool isStartFirstTime = true;
    public Button btnRestart;

    public Sprite btnIdle;
    public Sprite btnHover;
    public Sprite btnClick;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0;
    
        pnlEndGame.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0)&&isStartFirstTime)
            {
                StartGame();
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
            }
        }
    }
    public void GetPoint()
    {
        gamePoint--;
        txtPoint.text =   gamePoint.ToString()+ "%";
    }
    void StartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        StartGame();
    }
    public void EndGame()
    {
        isEndGame = true;
        isStartFirstTime = false;
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
        txtEndPoint.text = "Còn: " + gamePoint.ToString()+"% nửa \n\tlà bạn có thể bằng Quốc Đạt";
    }
    public void RestartButtonClick()
    {
        btnRestart.GetComponent<Image>().sprite = btnClick;
    }
    public void RestartButtonHover()
    {
        btnRestart.GetComponent<Image>().sprite = btnHover;
    }
    public void RestartButtonIdle()
    {
        btnRestart.GetComponent<Image>().sprite = btnIdle;
    }
}