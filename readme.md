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

### Prueba
![gif](ejercicio1/gif.gif)

# Escena con recolectables
Se ha creado una escena utilizando los siguientes assets: [terreno](https://assetstore.unity.com/packages/3d/environments/fantasy/fantasy-forest-environment-free-demo-35361), [monedas](https://assetstore.unity.com/packages/3d/props/simple-gems-and-items-ultimate-animated-customizable-pack-73764).

Luego se ha creado un objeto vacío que tiene como hijo una cámara con el componente Tracked Pose Driver que a su vez contiene como hijo un prefab CardboardReticlePointer obtenido de la escena de ejemplo.

En la escena, el jugador recoje las miradas con la vista. Para ello se ha asignado a cada moneda la capa `Interactive` y un [script](ejercicio2/Collectable.cs) que implementa el método OnPointEnter, el cual es llamado cuando este es alcanzado por el raycast.

### Prueba
![gif](ejercicio2/gif.gif)

# Recuperar recolectables

A continuación, se añade un elemento a la escena para que al mirarlo las monedas se muevan hacia el jugador. Para ello  se utiliza el siguiente asset de la assert store: [personaje](https://assetstore.unity.com/packages/3d/characters/humanoids/.fantasy/low-poly-stylized-cartoon-goblin-293432)

Se le añade como componente un [script](ejercicio3/Goblin.cs) que lanzará evento al mirarlo, siguiendo el patrón Observer. Además, se le coloca la capa `Interactive` para que pueda ser detectado por el raycast.

Luego se modifica el [script](ejercicio3/Collectable.cs) del apartado anterior para que las monedas se muevan a un punto concreto al recibir el mensaje.

### Prueba
![gif](ejercicio3/gif.gif)
