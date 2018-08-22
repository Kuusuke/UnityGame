using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame.GameScene
{
	public interface IGameSceneFactory
	{
		IGameScene Create(EGameSceneType gameSceneType);
	}
}
