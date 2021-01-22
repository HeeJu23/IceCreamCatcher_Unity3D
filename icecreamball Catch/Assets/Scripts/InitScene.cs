using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class InitScene : MonoBehaviour
{
    public GameObject icecream1;
    public GameObject icecream2;
    public GameObject icecream3;
    public GameObject icecream4;
    public GameObject icecream5;
    public GameObject monster;

    public Rigidbody ice1;
    public Rigidbody ice2;
    public Rigidbody ice3;
    public Rigidbody ice4;
    public Rigidbody ice5;
    public Rigidbody mon;


    private GameObject location1;
    private GameObject location2;
    private GameObject location3;
    private GameObject location4;
    private GameObject location5;
    private GameObject location_monster;
    public Text levelText;
    public Text correctText;
    public Text lifeText;
    public int level = 1;
    public int correct = 0;
    public static int life = 3; 
    public bool isSame = false;
    public int[] userIcecream = new int[3];
    public int[] systemIcecream = new int[3];

    public GameObject gameoverPanel;
    public GameObject gameclearPanel;
    public GameObject gamepausePanel;
    bool IsPause;


    void Start()
    {
        icecream1 = (GameObject)Resources.Load("Chocolate");
        icecream2 = (GameObject)Resources.Load("Greentea");
        icecream3 = (GameObject)Resources.Load("Vanila");
        icecream4 = (GameObject)Resources.Load("Strawberry");
        icecream5 = (GameObject)Resources.Load("Pistachio");
        monster = (GameObject)Resources.Load("Monster");
        InvokeRepeating("CreateIceCream", 1.0f, 2.5f);
        gameoverPanel.SetActive(false);
        gameclearPanel.SetActive(false);
        gamepausePanel.SetActive(false);

    }

    void Update()
    {
        levelText.text = "LEVEL : " + level.ToString();
        correctText.text = "CORRECT : " + correct.ToString();
        int life1 = MonsterControl.lifeCount;
        lifeText.text = "LIFE : " + life1.ToString();
        if (Input.GetKey(KeyCode.C))
        {
            CompleteMaking();
            Comparing();
            LevelUp();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (IsPause == false)
            {
                gamepausePanel.SetActive(true);
                Time.timeScale = 0;
                IsPause = true;
                return;
            }
            if (IsPause == true)
            {
                gamepausePanel.SetActive(false);
                Time.timeScale = 1;
                IsPause = false;
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameoverPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Reset();
        }
        if (life1 == 0)
        {
            gameoverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (gameoverPanel.activeSelf)
        {
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }
        if (gameclearPanel.activeSelf)
        {
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }


    }

    void CreateIceCream()
    {
        int x1 = Random.Range(-2, 10);
        int x2 = Random.Range(-2, 10);
        int x3 = Random.Range(-2, 10);
        int x4 = Random.Range(-2, 10);
        int x5 = Random.Range(-2, 10);
        int x6 = Random.Range(-2, 10);

        int z1 = Random.Range(-2, 8);
        int z2 = Random.Range(-2, 8);
        int z3 = Random.Range(-2, 8);
        int z4 = Random.Range(-2, 8);
        int z5 = Random.Range(-2, 8);
        int z6 = Random.Range(-2, 8);

        location1 = (GameObject)Instantiate(icecream1, new Vector3(x1 * 1.5f - 6, 18.0f, z1 * 1.5f - 6),
            Quaternion.Euler(0, 120, 0));
        location2 = (GameObject)Instantiate(icecream2, new Vector3(x2 * 1.5f - 6, 18.0f, z2 * 1.5f - 6),
            Quaternion.Euler(0, 120, 0));
        location3 = (GameObject)Instantiate(icecream3, new Vector3(x3 * 1.5f - 6, 18.0f, z3 * 1.5f - 6),
            Quaternion.Euler(0, 120, 0));
        location4 = (GameObject)Instantiate(icecream4, new Vector3(x4 * 1.5f - 6, 18.0f, z4 * 1.5f - 6),
            Quaternion.Euler(0, 120, 0));
        location5 = (GameObject)Instantiate(icecream5, new Vector3(x5 * 1.5f - 6, 18.0f, z5 * 2.0f - 6),
            Quaternion.Euler(0, 120, 0));
        location_monster = (GameObject)Instantiate(monster, new Vector3(x6 * 1.5f - 6, 18.0f, z6 * 2.0f - 6),
            Quaternion.Euler(0, 120, 0));
    }

    void CompleteMaking()
    {
        GameObject icecreamcone = GameObject.Find("icecreamcone");
        for (int count = 0; count < 3; count++)
        {
            if (icecreamcone.transform.GetChild(count).tag == "Chocolate")
            {
                userIcecream[count] = 0;
            }
            else if (icecreamcone.transform.GetChild(count).tag == "Greentea")
            {
                userIcecream[count] = 1;
            }
            else if (icecreamcone.transform.GetChild(count).tag == "Pistachio")
            {
                userIcecream[count] = 2;
            }
            else if (icecreamcone.transform.GetChild(count).tag == "Strawberry")
            {
                userIcecream[count] = 3;
            }
            else if (icecreamcone.transform.GetChild(count).tag == "Vanila")
            {
                userIcecream[count] = 4;
            }
        }
    }

    void Comparing()
    {
        int photoNumber = RandomImages.RandomInt;

        switch (photoNumber)
        {
            case 1:
                systemIcecream[0] = 0;
                systemIcecream[1] = 2;
                systemIcecream[2] = 1;
                break;
            case 2:
                systemIcecream[0] = 0;
                systemIcecream[1] = 2;
                systemIcecream[2] = 3;
                break;
            case 3:
                systemIcecream[0] = 0;
                systemIcecream[1] = 4;
                systemIcecream[2] = 2;
                break;
            case 4:
                systemIcecream[0] = 0;
                systemIcecream[1] = 4;
                systemIcecream[2] = 3;
                break;
            case 5:
                systemIcecream[0] = 1;
                systemIcecream[1] = 0;
                systemIcecream[2] = 4;
                break;
            case 6:
                systemIcecream[0] = 1;
                systemIcecream[1] = 3;
                systemIcecream[2] = 2;
                break;
            case 7:
                systemIcecream[0] = 1;
                systemIcecream[1] = 4;
                systemIcecream[2] = 0;
                break;
            case 8:
                systemIcecream[0] = 1;
                systemIcecream[1] = 4;
                systemIcecream[2] = 3;
                break;
            case 9:
                systemIcecream[0] = 2;
                systemIcecream[1] = 0;
                systemIcecream[2] = 3;
                break;
            case 10:
                systemIcecream[0] = 2;
                systemIcecream[1] = 3;
                systemIcecream[2] = 1;
                break;
            case 11:
                systemIcecream[0] = 2;
                systemIcecream[1] = 4;
                systemIcecream[2] = 0;
                break;
            case 12:
                systemIcecream[0] = 2;
                systemIcecream[1] = 4;
                systemIcecream[2] = 3;
                break;
            case 13:
                systemIcecream[0] = 3;
                systemIcecream[1] = 0;
                systemIcecream[2] = 2;
                break;
            case 14:
                systemIcecream[0] = 3;
                systemIcecream[1] = 2;
                systemIcecream[2] = 4;
                break;
            case 15:
                systemIcecream[0] = 3;
                systemIcecream[1] = 4;
                systemIcecream[2] = 0;
                break;
            case 16:
                systemIcecream[0] = 3;
                systemIcecream[1] = 4;
                systemIcecream[2] = 2;
                break;
            case 17:
                systemIcecream[0] = 4;
                systemIcecream[1] = 0;
                systemIcecream[2] = 3;
                break;
            case 18:
                systemIcecream[0] = 4;
                systemIcecream[1] = 1;
                systemIcecream[2] = 0;
                break;
            case 19:
                systemIcecream[0] = 4;
                systemIcecream[1] = 2;
                systemIcecream[2] = 3;
                break;
            case 20:
                systemIcecream[0] = 4;
                systemIcecream[1] = 3;
                systemIcecream[2] = 2;
                break;
        }
    }

    void LevelUp()
    {
        isSame = userIcecream.SequenceEqual(systemIcecream);
        Reset();
        GameObject.Find("Canvas").GetComponent<RandomImages>().ShowImage();
        if (isSame)
        {
            Debug.Log("Correct");
            correct++;

        }

        if (correct == 2)
        {
            level = 2;
            Physics.gravity = new Vector3(0, -9.8F, 0);


        }
        else if (correct == 4)
        {
            level = 3;
            Physics.gravity = new Vector3(0, -13.0F, 0);

        }
        else if (correct == 6)
        {
            gameclearPanel.SetActive(true);
            Time.timeScale = 0;

        }
        else
            return;


    }

    public void Reset()
    {
        GameObject icecreamcone = GameObject.Find("icecreamcone");
        for (int i = 0; i<3; i++)
        {
            Destroy(icecreamcone.transform.GetChild(i).gameObject);
        }

    }

    public void CompleteButton()
    {
        CompleteMaking();
        Comparing();
        LevelUp();
        Debug.Log(correct);
    }

}
