﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class CSInterfaceWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("CSInterface");
		L.RegFunction("SendCmd", SendCmd);
		L.RegFunction("SetServerAddr", SetServerAddr);
		L.RegFunction("GetServerType", GetServerType);
		L.RegFunction("SetServerType", SetServerType);
		L.RegFunction("DisconnectToServer", DisconnectToServer);
		L.RegFunction("LoginToServer", LoginToServer);
		L.RegFunction("UIRoot", UIRoot);
		L.RegFunction("SceneRoot", SceneRoot);
		L.RegVar("s_uiRoot", get_s_uiRoot, set_s_uiRoot);
		L.RegVar("s_sceneRoot", get_s_sceneRoot, set_s_sceneRoot);
		L.RegVar("s_recvProtoId", get_s_recvProtoId, set_s_recvProtoId);
		L.RegVar("s_recvBytes", get_s_recvBytes, set_s_recvBytes);
		L.RegVar("s_sendProtoId", get_s_sendProtoId, set_s_sendProtoId);
		L.RegVar("s_sendBytes", get_s_sendBytes, set_s_sendBytes);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendCmd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			bool o = CSInterface.SendCmd();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetServerAddr(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			ushort arg1 = (ushort)LuaDLL.luaL_checknumber(L, 2);
			CSInterface.SetServerAddr(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetServerType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			byte o = CSInterface.GetServerType();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetServerType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 1);
			CSInterface.SetServerType(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DisconnectToServer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			CSInterface.DisconnectToServer();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoginToServer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			CSInterface.LoginToServer();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UIRoot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Transform o = CSInterface.UIRoot();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SceneRoot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Transform o = CSInterface.SceneRoot();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_s_uiRoot(IntPtr L)
	{
		try
		{
			ToLua.Push(L, CSInterface.s_uiRoot);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_s_sceneRoot(IntPtr L)
	{
		try
		{
			ToLua.Push(L, CSInterface.s_sceneRoot);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_s_recvProtoId(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, CSInterface.s_recvProtoId);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_s_recvBytes(IntPtr L)
	{
		try
		{
			ToLua.Push(L, CSInterface.s_recvBytes);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_s_sendProtoId(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, CSInterface.s_sendProtoId);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_s_sendBytes(IntPtr L)
	{
		try
		{
			ToLua.Push(L, CSInterface.s_sendBytes);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_s_uiRoot(IntPtr L)
	{
		try
		{
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
			CSInterface.s_uiRoot = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_s_sceneRoot(IntPtr L)
	{
		try
		{
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
			CSInterface.s_sceneRoot = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_s_recvProtoId(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			CSInterface.s_recvProtoId = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_s_recvBytes(IntPtr L)
	{
		try
		{
			LuaByteBuffer arg0 = new LuaByteBuffer(ToLua.CheckByteBuffer(L, 2));
			CSInterface.s_recvBytes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_s_sendProtoId(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			CSInterface.s_sendProtoId = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_s_sendBytes(IntPtr L)
	{
		try
		{
			LuaByteBuffer arg0 = new LuaByteBuffer(ToLua.CheckByteBuffer(L, 2));
			CSInterface.s_sendBytes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

