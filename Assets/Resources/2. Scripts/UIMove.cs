using UnityEngine;
using System.Collections;

public class UIMove : UIBase {

    protected override void Awake()
    {
        base.Awake();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void CallCoroutine()
    {
        StartCoroutine(Move());
    }

    protected virtual IEnumerator Move()
    {
        yield return null;
    }

    public virtual void ClickInit()
    {
        
    }
}
