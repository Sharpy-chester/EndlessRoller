using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderManipulation : MonoBehaviour {

    public Material thisMat;

	void Awake () {
        Color color1 = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        Color color2 = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        thisMat.SetColor("Color_6E770BEA", color1);
        thisMat.SetColor("Color_21AD547B", color2);
        Vector2 offset = new Vector2(Random.Range(0f, 10f), Random.Range(0f, 10f));
        thisMat.SetVector("Vector2_3E213512", offset);
	}
}
