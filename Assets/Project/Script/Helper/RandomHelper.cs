using System.Collections.Generic;
using UnityEngine;

namespace VRProject
{
    public class RandomHelper : MonoBehaviour
    {
        internal static T GetRandom<T>(params T[] Params)
        {
            return Params[Random.Range(0, Params.Length)];
        }

        internal static T GetRandom<T>(List<T> Params)
        {
            return Params[Random.Range(0, Params.Count)];
        }
    }
}
