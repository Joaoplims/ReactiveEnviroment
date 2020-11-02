using UnityEngine;
using System.Collections;

namespace Assets.Scripts.Utils
{
    public class ChangeColor : MonoBehaviour
    {
        public Color Color1;
        public Color Color2;

        private Renderer renderer;
     
        void Start()
        {
            renderer = GetComponent<Renderer>();
            renderer.material.color = Color.Lerp(Color1, Color2, Random.Range(04, 1f));
        }

    }
}