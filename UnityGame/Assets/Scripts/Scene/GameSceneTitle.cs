using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGame.Platform;

namespace UnityGame.GameScene
{
	public class GameSceneTitle : MonoBehaviour, IGameScene
	{
		public EGameSceneType GameSceneType { get { return EGameSceneType.Title; } }

		/// <summary>
		/// シーン開始時処理
		/// </summary>
		public void OnEnter()
		{

		}

		/// <summary>
		/// リソース読み込み処理
		/// </summary>
		public void LoadResources()
		{

		}

		/// <summary>
		/// シーン更新処理
		/// </summary>
		public void Update()
		{
			
		}

		/// <summary>
		/// シーン終了時処理
		/// </summary>
		public void OnExit()
		{

		}
	}
}