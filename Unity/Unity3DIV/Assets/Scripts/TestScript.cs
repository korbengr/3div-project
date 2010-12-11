// Author: Sibrand Staessens

using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void test(){
		GameObject trex = GameObject.Find("trex_ori");
		ObjectScript script = (ObjectScript)trex.GetComponent("ObjectScript");
		script.clone(new Vector3((float)-1.5, (float)2.0, (float)3.7),Quaternion.identity);

		GameObject clone = GameObject.Find("trex_ori1");
		GameObject tafel = GameObject.Find("tafel");
		ObjectScript cloneScript = (ObjectScript) clone.GetComponent("ObjectScript");
		//cloneScript.setParentTransform(Camera.main.transform);
	}
	
	public void testStack(){
		GameObject tafel = GameObject.Find("Tafel");
		ObjectScript oscript = (ObjectScript)tafel.GetComponent("ObjectScript");
		
		GameObject ic = GameObject.Find("InputController");
		StackScript sscript = (StackScript)ic.GetComponent("StackScript");
		sscript.Begin(tafel);
	}
	
	public void testParentMove(){
		GameObject tafel = GameObject.Find("Tafel");
		tafel.transform.Translate(Vector3.forward * 2, Space.World);
	}
	public void testParentRotate(){
		GameObject tafel = GameObject.Find("Tafel");
		tafel.transform.RotateAround(tafel.transform.position, Vector3.up, 5);
	}
}
