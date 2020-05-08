using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMscript : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
