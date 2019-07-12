using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedRift.TestProject.Player
{
    /// <summary>
    /// Управление мячом
    /// </summary>
    public class BallController : MonoBehaviour
    {
        private Rigidbody2D m_Rigidbody2D;

        private void Awake()
        {
            m_Rigidbody2D = GetComponent< Rigidbody2D >( );
        }

        void Update( )
        {
            if ( Input.touchSupported )
            {
                if ( Input.touchCount > 0 )
                {
                    Touch firstTouch = Input.GetTouch( 0 );
                    ForceTo( firstTouch.position );
                }
            }
            else
            {
                if ( Input.GetMouseButton( 0 ) )
                {
                    ForceTo( Input.mousePosition );
                }
            }
        }

        private void ForceTo( Vector2 pos )
        {
            pos = Camera.main.ScreenToWorldPoint( pos );

            pos = ( pos - ( Vector2 ) transform.position ).normalized;

            m_Rigidbody2D.AddForce( pos, ForceMode2D.Impulse );
        }
    }
}