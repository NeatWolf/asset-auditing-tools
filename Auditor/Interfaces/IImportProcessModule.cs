﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssetTools
{
	public interface IImportProcessModule
	{
		List<IConformObject> GetConformObjects( string asset );
		bool GetSearchFilter( out string typeFilter, List<string> ignoreAssetPaths );

		void FixCallback( AssetDetailList calledFromTreeView, object context );
	}
}