using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame.Platform
{
	public class ApplicationInitializer : MonoBehaviour, IApplicationInitializer
	{
		public bool InitializeApplication()
		{
			return true;
		}

		private void Awake()
		{
			
		} 
	}
}