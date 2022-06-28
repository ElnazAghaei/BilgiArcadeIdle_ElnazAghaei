using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Count : MonoBehaviour
{
	public Text countText;
	public int count;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			count = count + 1;
		}
	}

}
