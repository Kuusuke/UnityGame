using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityGame.GameScene
{
	public class GameSceneManager : IGameSceneManager
	{
		private IGameSceneFactory gameSceneFactory = null;

		private IGameScene prevGameScene { get; set; } = new GameSceneNull();

		private IGameScene currentGameScene { get; set; } = new GameSceneInitialize();

		private static GameSceneManager instance = null;

		private GameSceneManager(IGameSceneFactory _gameSceneFactory)
		{
			gameSceneFactory = _gameSceneFactory;
		}

		public static GameSceneManager GetInstance()
		{
			if (instance == null)
			{
				IGameSceneFactory gameSceneFactory = new GameSceneFactory();
				instance = new GameSceneManager(gameSceneFactory);
			}
			
			return instance;
		}

		public bool ChangeGameScene(EGameSceneType _type)
		{
			if (prevGameScene.GameSceneType != _type)
			{
				IGameScene tempGameScene = prevGameScene;
				prevGameScene = currentGameScene;
				currentGameScene = tempGameScene;
			}
			else
			{
				prevGameScene = currentGameScene;
				currentGameScene = gameSceneFactory.Create(_type);
				SceneManager.LoadScene();
			}
			return true;
		}
	}
}