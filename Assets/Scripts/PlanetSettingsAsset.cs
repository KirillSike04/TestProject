using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedRift.TestProject
{
    [CreateAssetMenu]
    public class PlanetSettingsAsset : ScriptableObject
    {
        /// <summary>
        /// Значение гравитации планеты (м/с²)
        /// </summary>
        [Tooltip( "Значение гравитации планеты (м/с²)" )]
        public float Gravity;
        /// <summary>
        /// Цвет атмосферы планеты
        /// </summary>
        [Tooltip( "Цвет атмосферы планеты" )]
        public Color SkyColor;
    }
}