# Práctica 02. Movimiento.

## Índice

## Introducción
Este informe recoge el desarrollo de la Segunda Práctica de la asignatura Interfaces Inteligentes, la cuál ahonda en el movimiento de objetos dentro de una escena. Además, se sigue profundizando en el uso de scripts para programar los comportamientos deseados.

Una vez más, ha sido necesario visitar el [Manual de Unity](https://docs.unity3d.com/Manual/index.html) para aprender a usar diferentes clases y métodos tales como `Rotate` o `LookAt`.

## Ejercicio 05. Desplazamiento

El fichero con el código se encuentra en [Assets/Scripts/Ejercicio05_Desplazamiento.cs](Assets/Scripts/Ejercicio05_Desplazamiento.cs)

### Descripción
Mediante el uso de un objeto `Empty` con 3 posiciones, se pretendía que tras presionar la tecla `Espacio`, se desplazaran 3 objetos la distancia especificada. 

En el enunciado se propusieron dos formas de hacerlo: mediante un único objeto que centralizara el comportamiento (que es la implementación por la que he otpado) o mediante la inclusión de un script en los tres objetos que les dotara de un nuevo atributo que controlara el desplazamiento.

### Implementación
- Como ya he mencionado, he creado un objeto `Empty` en la escena al que le he agregado el script y que contó con tres atributos con los correspondientes desplazamientos.
- Además, gracias a que conozco que en *InputManager* el espacio se asocia a la acción *Jump*, pude identificar cuándo el usuario presionaba la tecla.
- Finalmente, sólo fue necesario calcular la nueva ditancia a partir de la inicial y del desplazamiento especificado.

### Ejecución
![](GIFs/Ejercicio05.gif)

