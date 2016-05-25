using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

    private static GM _gm;
    public static GM instance
    {
        get
        {
            if(!_gm)
            {
                _gm = GameObject.Find("GM").GetComponent<GM>();
                if(!_gm)
                {
                    GameObject container = new GameObject("GM");
                    _gm = container.AddComponent<GM>();
                }
            }
            return _gm;
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
