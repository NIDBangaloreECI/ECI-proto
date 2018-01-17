using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.nidb.data;

namespace com.nidb.ecigame.ui
{
	/**
	 * Implements the Episodes Menu screen
	 */
	public class MenuScreen : MonoBehaviour 
	{
		[SerializeField]
		private ECIGameEpisodes _episodesDatabase;

		[SerializeField]
		private Button _menuButtonTemplate;

		[SerializeField]
		private RectTransform _menuContentRoot;

		// Use this for initialization
		void Start () 
		{
			
		}
		
		// Update is called once per frame
		void Update () 
		{
			
		}
	}
}