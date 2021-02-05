using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFood : MonoBehaviour
{
	public GameObject[] foodPrefab = new GameObject[2];
	//public GameObject foodPrefab;
	public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {	
    	if(Input.GetKey("g")){
        	foodCreate();
    	}
    }



    void foodCreate(){
    	float number = Random.Range(-9.3f,9.3f);
        Instantiate(foodPrefab[Random.Range(0,2)], spawn.position + new Vector3(number, 0, 0), spawn.rotation);
    }
}
