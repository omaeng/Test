using UnityEngine;
using System.Collections;

[RequireComponent(typeof(RectTransform))]
public class UIBase : MonoBehaviour {
    
    public RectTransform _rTrans;

    protected virtual void Awake()
    {
        _rTrans = GetComponent<RectTransform>();
        if(_rTrans == null)
        {
            _rTrans = this.gameObject.AddComponent<RectTransform>();
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    virtual public void CallCoroutine()
    {
           
    }
    virtual public void CallCoroutine(int takeN)
    {

    }
}
