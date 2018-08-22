using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame.Platform
{
	/// <summary>
	/// リソース読み込みインターフェース
	/// </summary>
	public interface IResourceLoader
	{
		/// <summary>
		/// 読み込み
		/// </summary>
		/// <returns></returns>
		Object Load(string path);
	}
}