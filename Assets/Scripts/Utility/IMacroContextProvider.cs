﻿// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2017 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Hazelnut

namespace DaggerfallWorkshop.Utility
{
    /// <summary>
    /// Macro context provider interface to be implemented by object that needs to provide
    /// context for macros. Returns a macro data source containing applicable handler methods.
    /// </summary>
    public interface IMacroContextProvider
    {
        MacroDataSource GetMacroDataSource();
    }
}

