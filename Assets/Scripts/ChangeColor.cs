using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

/*public class ChangeColor : MonoBehaviour
{
    public Color[] colors = new Color[] { Color.red, Color.blue, Color.yellow, Color.green
};// Массив с четырьмя цветами

private Renderer renderer; // Компонент отвечающий за отображение объекта

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Проверяем, была ли нажата левая кнопка мыши
        {
            ChangeObjectColor(); // Вызываем функцию смены цвета
        }
    }

    void ChangeObjectColor()
    {
        Color newColor = colors[Random.Range(0, colors.Length)]; 
        renderer.material.color = newColor; 
    }
}*/





public class ChangeColor : MonoBehaviour
{
    public GameObject objectToChangeColor;
    private Renderer objectRenderer;
    public Color[] colors = new Color[] { Color.red, Color.blue, Color.yellow, Color.green
};
    void Start()
    {
        objectRenderer = objectToChangeColor.GetComponent<Renderer>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            ChangeObjectColor();
        }
        
    }

    void ChangeObjectColor()
    {
        Color newColor = colors[Random.Range(0, colors.Length)];
        objectRenderer.material.color = newColor;
    }
}

