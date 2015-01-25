using UnityEngine;
using System.Collections;

public class globalvariables : MonoBehaviour {

    public enum level { Title, Start, Broken, End}
    public level sceneLevel;
    //public level

	// Use this for initialization
	void Start () 
    {
        sceneLevel = level.Broken; // Change to title when finished testing
	}	
}
