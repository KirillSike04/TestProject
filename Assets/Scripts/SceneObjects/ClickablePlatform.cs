using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedRift.TestProject.SceneObjects
{
    [RequireComponent( typeof( SpriteRenderer ) )]
    public class ClickablePlatform : MonoBehaviour, IClickable
    {
        private const string PLAYER_TAG = "Player";

        //Спрайт платформы, значение записывается в OnValidate
        [SerializeField, HideInInspector]
        private SpriteRenderer m_SpriteRenderer;

        [SerializeField]
        [Tooltip( "Текущий цвет платформы" )]
        private Color m_PlatformColor = Color.black;

        /// <summary>
        /// Цвет платформы
        /// </summary>
        public Color Color
        {
            get
            {
                return m_PlatformColor;
            }
            set
            {
                m_PlatformColor = value;
                m_SpriteRenderer.color = value;
            }
        }

        /// <summary>
        /// Установить случайный цвет
        /// </summary>
        public void SetRandomColor()
        {
            Color = Random.ColorHSV();
        }

        #region Mono

        private void OnValidate()
        {
            m_SpriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Awake()
        {
            Color = m_PlatformColor;
        }

        private void OnMouseDown()
        {
            SetRandomColor();
        }

        private void OnCollisionEnter2D( Collision2D collision )
        {
            if ( collision.collider.tag == PLAYER_TAG )
            {
                SetRandomColor( );
            }
        }

        #endregion
    }
}