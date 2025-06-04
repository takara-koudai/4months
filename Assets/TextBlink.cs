using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBlink : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMesh text;
    public float blinkSpeed = 1f;
  

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerable BlinkText()
    {
        while(true)
        {
            enabled = !enabled;
            yield return new WaitForSeconds(1f / blinkSpeed);
        }
    }

}
