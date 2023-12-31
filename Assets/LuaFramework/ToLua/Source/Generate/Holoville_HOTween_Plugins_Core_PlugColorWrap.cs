﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Holoville_HOTween_Plugins_Core_PlugColorWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Holoville.HOTween.Plugins.Core.PlugColor), typeof(Holoville.HOTween.Plugins.Core.ABSTweenPlugin));
		L.RegFunction("New", _CreateHoloville_HOTween_Plugins_Core_PlugColor);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateHoloville_HOTween_Plugins_Core_PlugColor(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Color arg0 = ToLua.ToColor(L, 1);
				Holoville.HOTween.Plugins.Core.PlugColor obj = new Holoville.HOTween.Plugins.Core.PlugColor(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Color), typeof(Holoville.HOTween.EaseType)))
			{
				UnityEngine.Color arg0 = ToLua.ToColor(L, 1);
				Holoville.HOTween.EaseType arg1 = (Holoville.HOTween.EaseType)ToLua.CheckObject(L, 2, typeof(Holoville.HOTween.EaseType));
				Holoville.HOTween.Plugins.Core.PlugColor obj = new Holoville.HOTween.Plugins.Core.PlugColor(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Color), typeof(bool)))
			{
				UnityEngine.Color arg0 = ToLua.ToColor(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				Holoville.HOTween.Plugins.Core.PlugColor obj = new Holoville.HOTween.Plugins.Core.PlugColor(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Color), typeof(Holoville.HOTween.EaseType), typeof(bool)))
			{
				UnityEngine.Color arg0 = ToLua.ToColor(L, 1);
				Holoville.HOTween.EaseType arg1 = (Holoville.HOTween.EaseType)ToLua.CheckObject(L, 2, typeof(Holoville.HOTween.EaseType));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				Holoville.HOTween.Plugins.Core.PlugColor obj = new Holoville.HOTween.Plugins.Core.PlugColor(arg0, arg1, arg2);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Color), typeof(UnityEngine.AnimationCurve), typeof(bool)))
			{
				UnityEngine.Color arg0 = ToLua.ToColor(L, 1);
				UnityEngine.AnimationCurve arg1 = (UnityEngine.AnimationCurve)ToLua.CheckObject(L, 2, typeof(UnityEngine.AnimationCurve));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				Holoville.HOTween.Plugins.Core.PlugColor obj = new Holoville.HOTween.Plugins.Core.PlugColor(arg0, arg1, arg2);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Holoville.HOTween.Plugins.Core.PlugColor.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

