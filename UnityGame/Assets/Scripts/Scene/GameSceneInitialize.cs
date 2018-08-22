using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityGame.GameScene
{
	public class GameSceneInitialize : MonoBehaviour, IGameScene
	{
		public EGameSceneType GameSceneType { get { return EGameSceneType.Initialize; } }
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
			if (Input.GetKeyDown(KeyCode.Return))
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene("LoadingScene");
			}
		}

		/// <summary>
		/// シーン終了時処理
		/// </summary>
		public void OnExit()
		{

		}

		private void Awake()
		{
			Debug.Log("Awake");
		}

		private void OnEnable()
		{
			Debug.Log("OnEnable");
		}

		private void Start()
		{
			Debug.Log("Start");
		}

		private void OnDestroy()
		{
			Debug.Log("OnDestroy");
		}
	}
}