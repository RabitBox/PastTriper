using UnityEngine;
using System.Collections;

/// <summary>
/// 入力を管理する
/// </summary>
public class InputManager : MonoBehaviour {
    //--------------------------------------------------
    // Variable
    //--------------------------------------------------
    private static InputManager instance = null;

    //--------------------------------------------------
    // Property
    //--------------------------------------------------
    public InputManager Instance
    {
        get
        {
            if (instance == null) instance = this;
            return instance;
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
