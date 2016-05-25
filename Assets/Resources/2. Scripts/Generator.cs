using UnityEngine;
using System.Collections;

public abstract class Generator : MonoBehaviour {
    
    [SerializeField]
    protected GameObject[] _prefab;
    
    abstract protected void Generate();
}