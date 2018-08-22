using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame.Platform
{
	/// <summary>
	/// リソース読み込みクラス
	/// </summary>
	public class ResourceLoader : IResourceLoader
	{
		/// <summary>
		/// 読み込み
		/// </summary>
		/// <returns></returns>
		public Object Load(string path)
		{
			return Resources.Load(path);
		}
	}
}