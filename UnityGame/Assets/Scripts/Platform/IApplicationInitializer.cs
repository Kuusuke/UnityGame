using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame.Platform
{
	public interface IApplicationInitializer
	{
		bool InitializeApplication();
	}
}