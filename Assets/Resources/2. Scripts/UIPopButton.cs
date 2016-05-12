/////////////////////////////////////////////
// UIPopButton.cs			               //
/////////////////////////////////////////////
//  2016.04.12  오명훈 created             //
/////////////////////////////////////////////
// UIPopButton를 조정하는 스크립트입니다.  //
/////////////////////////////////////////////
using UnityEngine;
using System.Collections;

public class UIPopButton : UIButton {

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

    public override void CallFnc(int takeN)
    {
        base.CallFnc(takeN);
        CallPopupWin();
    }

    public void CallPopupWin()
    {
        ShowPopWin();
    }
    
    private void ShowPopWin()
    {
        Debug.Log("ShowPopWin");
    }
}
