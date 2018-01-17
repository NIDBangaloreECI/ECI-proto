using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

namespace com.nidb.data
{
	[System.Serializable]
	public class ECIGameEpisodeInfo
	{
		[Tooltip("The name of the episode")]
		[SerializeField]
		private string _name;

		[Tooltip("The starting scene for the episode")]
		[SerializeField]
		private string _sceneName;

		public string pName { get { return _name; } }
		public string pSceneName { get { return _sceneName; } }
	}

	public class ECIGameEpisodes : ScriptableObject 
	{
		[Tooltip("Lists all active episodes in the game")]
		[SerializeField]
		private ECIGameEpisodeInfo[] _episodes;

		[MenuItem("NIDB/ECI Game Tools/Data/Create Game Episodes List")]
		public static void CreateAsset()
		{
			ECIGameEpisodes obj = ScriptableObject.CreateInstance<ECIGameEpisodes>();
			string path = AssetDatabase.GetAssetPath(Selection.activeObject);
			if(string.IsNullOrEmpty(path))
				path = "Assets";
			string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/" + typeof(ECIGameEpisodes).ToString() + ".asset");
			AssetDatabase.CreateAsset(obj, assetPathAndName);
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}

		public void LoadEpisode(int episodeIndex)
		{
			if(episodeIndex >= 0 && episodeIndex < _episodes.Length)
				SceneManager.LoadScene(_episodes[episodeIndex].pSceneName);
		}
	}
}