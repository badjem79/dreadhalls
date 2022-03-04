using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLevel : MonoBehaviour
{
    private Text level;
    // Start is called before the first frame update
    void Start()
    {
        level = gameObject.GetComponent<Text>();
        level.text = "Level: " + DontDestroy.level;
    }

}
