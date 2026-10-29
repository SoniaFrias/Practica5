# Práctica 5
Práctica 5 de Interfaces Inteligentes

* **Autor:** Sonia Frías Jiménez 
* **ALU** alu0101492513@ull.edu.es
* **Versión de Unity:** 6.6
<details>
  <summary><b>Índice de ejercicios</b></summary>

  1. [Proyecto Cardboard y generación de la APK](#Proyecto-Cardboard-y-generación-de-la-APK)
  2. [Escena con recolectables](Escena-con-recolectables)
  3. [Recuperar recolectables](Recuperar-recolectables)

</details>

# Proyecto Cardboard y generación de la APK
Para realizar este paso se han seguido las instrucciones para [cardboard de Unity](https://developers.google.com/cardboard/develop/unity/quickstart?hl=es-419)

![gif](ejercicio1/gif.gif)

# Escena con recolectables
Se ha creado una escena utilizando los siguientes assets: [terreno](https://assetstore.unity.com/packages/3d/environments/fantasy/fantasy-forest-environment-free-demo-35361), [monedas](https://assetstore.unity.com/packages/3d/props/simple-gems-and-items-ultimate-animated-customizable-pack-73764).

El jugador recoje las miradas con la vista, para ello se ha asignado a cada moneda la capa `Interactive` y un [script](ejercicio2/Collectable.cs) que implementa el método OnPointEnter, el cual es llamado cuando este es alcanzado por el raycast.

![gif](ejercicio2/gif.gif)

# Recuperar recolectables
