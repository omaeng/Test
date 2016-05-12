/////////////////////////////////
// UIImageColorChange.cs       //
/////////////////////////////////
//  2016.03.27  오명훈 created //
/////////////////////////////////
// UI의 Image와 관련된 스크립트//
// 들의 기본이 되는 스크립트입 //
// 입니다.                     //
/////////////////////////////////
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UIImage : MonoBehaviour {

    public Image _image;

    protected virtual void Awake()
    {
        _image = GetComponent<Image>();
        if(_image == null)
        {
            Debug.Log("Image클래스가 등록된 오브젝트에 스크립트를 넣어주세요.");
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public virtual void CallCoroutine(int takeN)
    {
        StartCoroutine(Change(takeN));
    }

    protected virtual IEnumerator Change(int takeN)
    {
        yield return null;
    }
}
