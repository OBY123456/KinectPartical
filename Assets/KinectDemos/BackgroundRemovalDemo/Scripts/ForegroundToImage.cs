using UnityEngine;
using System.Collections;

public class ForegroundToImage : MonoBehaviour 
{

	void Update () 
	{
		BackgroundRemovalManager backManager = BackgroundRemovalManager.Instance;

		if(backManager && backManager.IsBackgroundRemovalInitialized())
		{
			Texture Texture = GetComponent<Texture>();

			//if(Texture && Texture.texture == null)
			//{
			//	Texture.texture = backManager.GetForegroundTex();
			//}
		}
	}

}
