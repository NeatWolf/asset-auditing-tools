﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace AssetTools
{

	public interface IPreprocessor
	{
		void OnPreprocessAsset( AssetImporter importer );
	}

}