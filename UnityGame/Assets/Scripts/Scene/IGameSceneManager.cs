using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame.GameScene
{
	public interface IGameSceneManager
	{
		bool ChangeGameScene(EGameSceneType _type);
	}
}