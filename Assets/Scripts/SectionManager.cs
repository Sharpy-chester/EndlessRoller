using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SectionManager : MonoBehaviour {

    public List<GameObject> sections;
    public GameObject ball;
    public GameObject ballObjForSpawn;
    public int sectionID = 1;
    public Text scoreText;
    public int score = 0;
    public GameObject gameOverScreen;
    bool ballIsActive = true;
    Vector3 mCameraPos;
    Vector3 thisSecPos;
    GameObject[] allRedObjects;

    void Awake()
    {
        mCameraPos = Camera.main.transform.position;
        allRedObjects = GameObject.FindGameObjectsWithTag("Red");
        for (int i = 0; i < allRedObjects.Length; i++)
        {
            allRedObjects[i].SetActive(false);
        }
        foreach (GameObject x in allRedObjects)
        {
            x.SetActive(false);
        }
    }

    void Update () {
        if (ballIsActive)
        {
            if (ball.transform.position.x >= ballObjForSpawn.transform.position.x)
            {
                int randomNum = Random.Range(0, sections.Count);
                ballObjForSpawn.transform.localPosition = new Vector3(ballObjForSpawn.transform.localPosition.x + 24, ballObjForSpawn.transform.localPosition.y, ballObjForSpawn.transform.localPosition.z);
                GameObject section = Instantiate(sections[randomNum], new Vector3(ballObjForSpawn.transform.position.x, ballObjForSpawn.transform.position.y, ballObjForSpawn.transform.position.z), this.transform.rotation);
                Section sectionScript = section.GetComponent<Section>();
                thisSecPos = section.transform.position;
                sectionID++;
                sectionScript.sectionID = sectionID;
                score++;
                scoreText.text = "Score: " + score.ToString();
            }
            if (ball.transform.position.y <= thisSecPos.y - 10)
            {

                ballIsActive = false;
                Destroy(ball);
                gameOverScreen.SetActive(true);
            }
            mCameraPos = new Vector3(ball.transform.position.x, ball.transform.position.y + 2, this.transform.position.z + -9.931f);
            Camera.main.transform.position = mCameraPos;
        }
        
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    
}
