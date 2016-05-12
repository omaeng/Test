using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

    private static GM _instance;
    public static GM instance
    {
        get
        {
            if(!_instance)
            {
                _instance = GameObject.Find("GM").GetComponent<GM>();
                if(!_instance)
                {
                    GameObject container = new GameObject();
                    container.name = "GM";
                    _instance = container.AddComponent<GM>();
                }
            }

            return _instance;
        }
    }

    void Awake()
    {
        Debug.Log("Start");
		DontDestroyOnLoad(this.gameObject);
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
