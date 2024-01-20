using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valrok.Saving.PlayerPrefs
{
    /// <summary>
    /// Sets playerprefs data and manages it
    /// </summary>
    public static class PlayerPrefsManager
    {
        public static void SetString(string key, string value)
        {
            UnityEngine.PlayerPrefs.SetString(key, value);
        }

        public static void SetInt(string key, int value)
        {
            UnityEngine.PlayerPrefs.SetInt(key, value);
        }

        public static void SetBool(string key, bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(key, value == true ? 1 : 0);
        }

        public static string GetString(string key)
        {
           return UnityEngine.PlayerPrefs.GetString(key);
        }

        public static int GetInt(string key)
        {
            return UnityEngine.PlayerPrefs.GetInt(key);
        }

        public static bool GetBool(string key)
        {
            bool value = UnityEngine.PlayerPrefs.GetInt(key) > 0 ? true : false;
            return value;
        }

        public static void Delete(string key)
        {
            UnityEngine.PlayerPrefs.DeleteKey(key);
        }
    }
}
