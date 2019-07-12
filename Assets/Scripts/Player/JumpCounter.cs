using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedRift.TestProject.Player
{
    /// <summary>
    /// Счётчик прыжков мяча, считает каждое соприкосновение с объектами
    /// </summary>
    public class JumpCounter : MonoBehaviour
    {
        private const string JUMP_COUNT_KEY = "JumpCount";
        
        /// <summary>
        /// Число прыжков
        /// </summary>
        public static int JumpCount
        {
            get
            {
                if ( m_JumpCount == 0 )
                {
                    m_JumpCount = LoadFromPrefs( );
                }

                return m_JumpCount;
            }
            private set
            {
                m_JumpCount = value;
            }
        }

        private static int m_JumpCount;

        #region Mono

        private void OnCollisionEnter2D( Collision2D collision )
        {
            //При соприкосновении с ЛЮБЫМ объектом,
            //увеличить счётчик
            JumpCount++;
        }

        private void OnDestroy()
        {
            //При уничтожении объекта 
            //записать значение
            SaveToPrefs( );
        }

        #endregion

        #region Prefs

        private void SaveToPrefs( )
        {
            PlayerPrefs.SetInt( JUMP_COUNT_KEY, JumpCount );
        }

        private static int LoadFromPrefs( )
        {
            return PlayerPrefs.GetInt( JUMP_COUNT_KEY, 0 );
        }

        [ContextMenu( "ClearPrefs" )]
        private void ClearPrefs( )
        {
            PlayerPrefs.SetInt( JUMP_COUNT_KEY, 0 );
        }

        #endregion
    }
}