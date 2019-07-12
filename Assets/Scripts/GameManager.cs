using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedRift.TestProject
{
    public class GameManager : MonoBehaviour
    {
        /// <summary>
        /// Ассет с настройками планет.
        /// Перед началом игры следует установить значение для загрузки настроек.
        /// </summary>
        public static PlanetSettingsAsset planetSettings;

        //Основная камера, для которой меняется цвет фона
        private Camera mainCamera;

        private void Awake()
        {
            if ( planetSettings == null )
            {
                Debug.LogError( "PlanetSettings is null." );
            }
            else
            {
                Debug.LogFormat( "Ball on the planet {0}, gravity value - {1}m/s².", planetSettings.name, planetSettings.Gravity );

                mainCamera = Camera.main;
                SetPlanetPhysics( );
                SetSkyColor( );
            }
        }

        private void OnDestroy()
        {
            //При смене сцены установить в дефолтное значение null
            planetSettings = null;
        }

        //Изменение величины гравитации
        private void SetPlanetPhysics( )
        {
            Vector2 planetGravity = new Vector2( 0, -planetSettings.Gravity );
            Physics2D.gravity = planetGravity;
        }

        //Изменение цвета фона
        private void SetSkyColor( )
        {
            mainCamera.clearFlags = CameraClearFlags.SolidColor;
            mainCamera.backgroundColor = planetSettings.SkyColor;
        }
    }
}