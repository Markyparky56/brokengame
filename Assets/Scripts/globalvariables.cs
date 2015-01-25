using UnityEngine;
using System.Collections;

public class globalvariables : MonoBehaviour {

    public enum level { Title, Start, Broken, End}
    public level sceneLevel;
    public bool doorLocked;
    public bool trapTriggered;
    public bool entranceTriggered;
    public bool freezePlayer;

	// Use this for initialization
	void Start () 
    {
        doorLocked = true;
        trapTriggered = false;
        entranceTriggered = false;
        freezePlayer = false;
        sceneLevel = level.Broken; // Change to title when finished testing
	}	
}
