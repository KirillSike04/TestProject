using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using RedRift.TestProject.Player;

namespace RedRift.TestProject.UI
{
    public class JumpCountText : MonoBehaviour
    {
        private const string INFO_DEFAULT_TEXT = "BallHit:";

        [Tooltip( "Информационный текст (Число прыжков: )" )]
        [SerializeField]
        private Text infoText;

        [Tooltip( "Количество прыжков (Значение)" )]
        [SerializeField]
        private Text countText;

        private void Start( )
        {
            if ( infoText )
            {
                infoText.text = INFO_DEFAULT_TEXT;
            }

            if ( countText )
            {
                countText.text = JumpCounter.JumpCount.ToString( );
            }
        }
    }
}