using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RedRift.TestProject.UI
{
    public class SceneSwitcher : MonoBehaviour
    {
        private const string GAME_LEVEL_NAME = "Game";
        private const string MENU_LEVEL_NAME = "Menu";

        /// <summary>
        /// Загрузить игровой уровень
        /// </summary>
        /// <param name="planetSettings">Настройки планеты, на которой будет мяч</param>
        public void LoadGameLevel( PlanetSettingsAsset planetSettings )
        {
            GameManager.planetSettings = planetSettings;
            SceneManager.LoadScene( GAME_LEVEL_NAME );
        }

        /// <summary>
        /// Вернуться в игровое меню
        /// </summary>
        public void BackToMenu()
        {
            SceneManager.LoadScene( MENU_LEVEL_NAME );
        }

        private void Update()
        {
            if ( !SceneManager.GetActiveScene( ).name.Equals( MENU_LEVEL_NAME ) )
            {
                //KeyCode.Escape = кнопке Back
                if ( Input.GetKeyDown( KeyCode.Escape ) )
                {
                    //Выход в меню по нажатию кнопки назад
                    BackToMenu( );
                }
            }
        }
    }
}