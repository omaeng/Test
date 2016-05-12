/////////////////////////////////
// UIImageChange.cs            //
/////////////////////////////////
//  2016.03.28  오명훈 created //
/////////////////////////////////
// UI의 Image를      변경하는  //
//  스크립트입니다.            //
/////////////////////////////////
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIImageChange : UIImage {

    [SerializeField] private Sprite[] _sprite = new Sprite[4];

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    protected override void Awake()
    {
        base.Awake();
        _image.sprite = _sprite[0];
    }

    protected override IEnumerator Change(int takeN)
    {
        _image.sprite = _sprite[takeN];

        yield return null;
    }
}
