/////////////////////////////////////////////
// UIButton.cs			                   //
/////////////////////////////////////////////
//  2016.04.12  오명훈 created             //
/////////////////////////////////////////////
// UIButton을 조정하는 스크립트들의 기본   //
// 스크립트입니다.		                   //
/////////////////////////////////////////////
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UIButton : MonoBehaviour {

    [SerializeField] private Button _button;
	private int givenNum;

    protected virtual void Awake()
    {
        _button = this.GetComponent<Button>();
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public virtual void CallFnc(int takeN)
	{
        SetGivenNum(takeN);
	}

	private void SetGivenNum(int takeN)
	{
		givenNum = takeN;
	}
}
