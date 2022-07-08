using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Designer : MonoBehaviour
{   

    //Polybius1981 fontSize = 33.7
    //Early GameBoy fontSize = 19.04; 
    //Futura Pt heavy fontSize = 26
    public TMP_FontAsset font;
    public float fontSize;
    public bool upper;
    private TMP_Text target;

    void Start()
    {
        if(GameObject.Find("small"))
        {
            target = GameObject.Find("small").GetComponent<TMP_Text>();
            target.font = font;
            target.fontSize = fontSize;
            if(upper) target.text = target.text.ToUpper();
            else target.text = target.text.ToLower();
            
            if(GameObject.Find("4"))
            {
                target = GameObject.Find("txt (1)").GetComponent<TMP_Text>();
                target.font = font;
                target.fontSize = fontSize;
                if(upper) target.text = target.text.ToUpper();
                else target.text = target.text.ToLower();
                target = GameObject.Find("txt (2)").GetComponent<TMP_Text>();
                target.font = font;
                target.fontSize = fontSize;
                if(upper) target.text = target.text.ToUpper();
                else target.text = target.text.ToLower();
                target = GameObject.Find("txt (3)").GetComponent<TMP_Text>();
                target.font = font;
                target.fontSize = fontSize;
                if(upper) target.text = target.text.ToUpper();
                else target.text = target.text.ToLower();
                target = GameObject.Find("txt (4)").GetComponent<TMP_Text>();
                target.font = font;
                target.fontSize = fontSize;
                if(upper) target.text = target.text.ToUpper();
                else target.text = target.text.ToLower();
            }
            if(GameObject.Find("3"))
            {
                target = GameObject.Find("txt (1)").GetComponent<TMP_Text>();
                target.font = font;
                target.fontSize = fontSize;
                if(upper) target.text = target.text.ToUpper();
                else target.text = target.text.ToLower();
                target = GameObject.Find("txt (2)").GetComponent<TMP_Text>();
                target.font = font;
                target.fontSize = fontSize;
                if(upper) target.text = target.text.ToUpper();
                else target.text = target.text.ToLower();
                target = GameObject.Find("txt (3)").GetComponent<TMP_Text>();
                target.font = font;
                target.fontSize = fontSize;
                if(upper) target.text = target.text.ToUpper();
                else target.text = target.text.ToLower();
            }
            else if(GameObject.Find("2"))
            {
                target = GameObject.Find("txt (1)").GetComponent<TMP_Text>();
                target.font = font;
                target.fontSize = fontSize;
                if(upper) target.text = target.text.ToUpper();
                else target.text = target.text.ToLower();
                target.font = font;
                target = GameObject.Find("txt (2)").GetComponent<TMP_Text>();
                target.fontSize = fontSize;
                if(upper) target.text = target.text.ToUpper();
                else target.text = target.text.ToLower();
            }// ahsdjkfhkjasdkjfhasdfhkjasdfjkasdkjfjhksdfkjhdjdjdjdj
        }
        else if(GameObject.Find("Story"))
        {
            target = GameObject.Find("big").GetComponent<TMP_Text>();
            target.font = font;
            target.fontSize = fontSize;
            if(upper) target.text = target.text.ToUpper();
            else target.text = target.text.ToLower();
            target = GameObject.Find("btnTxt").GetComponent<TMP_Text>();
            target.font = font;
            target.fontSize = fontSize;
            if(upper) target.text = target.text.ToUpper();
            else target.text = target.text.ToLower();
        }
    }
}
