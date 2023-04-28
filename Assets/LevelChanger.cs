using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelChanger : MonoBehaviour
{

    private string Level = "";

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetLevel(string level){
        Level = level;
    }

    public void ChangeLevel(){
        SceneManager.LoadScene(Level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
