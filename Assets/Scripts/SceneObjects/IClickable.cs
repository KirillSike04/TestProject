using UnityEngine;

namespace RedRift.TestProject.SceneObjects
{
    /// <summary>
    /// Нажимаемый объект
    /// </summary>
    public interface IClickable
    {
        /// <summary>
        /// Цвет объекта
        /// </summary>
        Color Color { get; set; }
        /// <summary>
        /// Поменять цвет на случайный
        /// </summary>
        void SetRandomColor( );
    }
}
