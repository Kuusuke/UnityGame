using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame.GameScene
{
	public class GameSceneFactory : IGameSceneFactory
	{
		private readonly IGameScene nullGameScene = new GameSceneNull();

		public IGameScene Create(EGameSceneType type)
		{
			IGameScene GameScene = null;

			switch (type)
			{
				case EGameSceneType.Initialize:
				GameScene = new GameSceneInitialize();
				break;

				case EGameSceneType.Loading:
				GameScene = new GameSceneLoading();
				break;

				case EGameSceneType.Title:
				GameScene = new GameSceneTitle();
				break;

				case EGameSceneType.MainGame:
				GameScene = new GameSceneMainGame();
				break;
			}

			return GameScene;
		}
	}
}