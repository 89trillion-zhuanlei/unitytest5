using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace SG
{
    [RequireComponent(typeof(UnityEngine.UI.LoopScrollRect))]
    [DisallowMultipleComponent]
    public class InitOnStart : MonoBehaviour
    {
        public int totalCount;
        void Start()
        {
            totalCount = 10;
            var ls = GetComponent<LoopScrollRect>();
            ls.totalCount = totalCount;
            ls.RefillCells();
        }
    }
}