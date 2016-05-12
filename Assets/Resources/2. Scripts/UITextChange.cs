/////////////////////////////////
// UITextChange.cs		       //
/////////////////////////////////
//  2016.04.07  오명훈 created //
/////////////////////////////////
// UI의 Text의 문자열을 바꾸는 //
// 스크립트입니다.		       //
/////////////////////////////////
using UnityEngine;
using System.Collections;

public class UITextChange : UIText {

	[SerializeField] private string[] _title = new string[4];

	protected override void Awake()
	{
		base.Awake();
		_text.text = _title[0];
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	protected override IEnumerator Change (int takeN)
	{
		_text.text = _title[takeN];
		yield return null;
	}
}
