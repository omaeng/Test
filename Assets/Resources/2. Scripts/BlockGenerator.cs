using UnityEngine;
using System.Collections;
using System;

public class BlockGenerator : Generator {

    static private BlockGenerator _blockGenerator;
    static public BlockGenerator Instance
    {
        get
        {
            if (!_blockGenerator)
            {
                _blockGenerator = GameObject.FindObjectOfType<BlockGenerator>();
                if (!_blockGenerator)
                {
                    GameObject container = new GameObject("BlockGenerator");
                    _blockGenerator = container.AddComponent<BlockGenerator>();
                }
            }
            return _blockGenerator;
        }
    }

    protected override void Generate()
    {
        throw new NotImplementedException();
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
