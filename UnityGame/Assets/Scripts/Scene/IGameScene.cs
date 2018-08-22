using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGame.Platform;

namespace UnityGame.GameScene
{
	/// <summary>
	/// シーンクラスインターフェース
	/// </summary>
	public interface IGameScene
	{
		EGameSceneType GameSceneType { get; }

		/// <summary>
		/// シーン開始時処理
		/// </summary>
		void OnEnter();

		/// <summary>
		/// リソース読み込み処理
		/// </summary>
		void LoadResources();

		/// <summary>
		/// シーン更新処理
		/// </summary>
		void Update();

		/// <summary>
		/// シーン終了時処理
		/// </summary>
		void OnExit();
	}
}