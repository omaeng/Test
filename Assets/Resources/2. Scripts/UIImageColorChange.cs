/////////////////////////////////
// UIImageColorChange.cs       //
/////////////////////////////////
//  2016.03.28  오명훈 created //
/////////////////////////////////
// UI의 Image의 색을 변경하는  //
//  스크립트입니다.            //
/////////////////////////////////
using UnityEngine;
using System.Collections;

public class UIImageColorChange : UIImage {

    [SerializeField]
    private Color[] _color = new Color[4];

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected override void Awake()
    {
        base.Awake();
        _image.color = _color[0];
    }

    protected override IEnumerator Change(int takeN)
    {
        _image.color = _color[takeN];
        yield return null;
    }
}
