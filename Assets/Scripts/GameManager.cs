using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private static GameManager manager = null;
    private enum GameState { Game, End };
    

    public GUIStyle style1;
    public GUIStyle style2;
    private static int score = 0;

    private string score_txt = "";


    GameState gameState = GameState.Game;

    public static GameManager Manager
    {
        get
        {
            if (manager == null) manager = new GameObject("GameManager").AddComponent<GameManager>();
            return manager;
        }
    }

    void Awake()
    {
        if((manager) && (manager.GetInstanceID() != GetInstanceID()))
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            manager = this;
            DontDestroyOnLoad(gameObject);
        }

        manager = this;
    }
    
    void Start()
    {
        score = 0;
        gameState = GameState.Game;
    }
    void Update()
    {
        score_txt = score.ToString();

    }
    void OnGUI()
    {
        
        if (gameState == GameState.Game)
        {
            DisplayInGameHUD();
        }
    }
    public void AddScore(int amount)
    {
        score += amount;
    }

    void DisplayInGameHUD()
    {
        GUI.Label(new Rect(10, 10, 40, 10), "PONTIN: " + score_txt, style1);

        GUI.Label(new Rect(20, 50, 60, 10), "ARRASTA ESSI PEIXI", style1);

    }
}
