/////////////////////////////////////////////
// UIPopButtonMng.cs		               //
/////////////////////////////////////////////
//  2016.04.12  오명훈 created             //
/////////////////////////////////////////////
// UIPopButton을 관리하는 스크립트입니다.  //
/////////////////////////////////////////////
using UnityEngine;
using System.Collections;

public class UIPopButtonMng : MonoBehaviour {

    [SerializeField] private UITextChange _child;
    [SerializeField] private Animator _anim;
    void Awake()
    {
        _child = gameObject.GetComponentInChildren<UITextChange>();
        _anim = gameObject.GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {

    }

    private void ChildTxtChange(int takeN)
    {
        _child.CallCoroutine(takeN);
    }

    public void PlayClickAnim()
    {
        _anim.SetTrigger("Pressed");
    }

    public void CallFunc(int takeN)
    {
        AnimMng(takeN);
        this.SendMessage("CallFnc", takeN);
    }

    private void AnimMng(int takeN)
    {
        switch (takeN % 2)
        {
            case 1:
                TrueAnim("Show");
                break;
            default:
                TrueAnim("Hide");
                break;
        }
    }

    private void TrueAnim(string _property)
    {
        _anim.SetBool(_property, true);
    }

    private void FalseAnim(string _property)
    {
        _anim.SetBool(_property, false);
    }

    public void InActive()
    {
        this.gameObject.SetActive(false);
    }
}
