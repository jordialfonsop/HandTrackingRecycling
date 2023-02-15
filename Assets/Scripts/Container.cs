using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    [SerializeField]
    protected GameObject ContainerObject;

    protected GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        this.tag = ContainerObject.tag;
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == this.tag)
        {
            GameObject.Destroy(other.gameObject);
            GameManager.SetScore(1,1);
        }
    }
}
