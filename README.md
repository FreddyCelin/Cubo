# Cube Summation
Mediante una matriz 3D dados tres puntos x,y,z se actualiza w, se calcula la suma del valor de los bloques.


Introducción del proyecto 🚀
--------------------------
El proyecto Cube se le da una Matriz 3-D en la que cada bloque contiene 0 inicialmente. El primer bloque está definido por la coordenada (1,1,1) y el último bloque está definido por la coordenada (N, N, N). Hay dos tipos de consultas.
UPDATE x y z W
actualiza el valor del bloque (x, y, z) a W.

QUERY x1 y1 z1 x2 y2 z2
calcula la suma del valor de los bloques cuya coordenada x está entre x1 y x2 (inclusive), la coordenada y entre y1 e y2 (inclusive) y la coordenada z entre z1 y z2 (inclusive).


Este proyecto fue desarrollado en cuatro capas que consta:
	1. Capa de presentación, en este proyecto se capturan los datos por parte del usuario.
	2. Capa de lógica, se encuentran los metodos UPDATE (actualiza el cubo) y QUERY (calcula los valores).
	3. Capa transversal, aquí se encuentran las clases point (x,y,z,w), la clase QueryDatos (x1,y1,z1,x2,y2,z2) y una clase que define los textos del app.
	4. Capa de pruebas unitarias, en este proyecto se pueden ejecutar las pruebas para verificar el correcto funcionamiento de los métodos que se encuentrar en la lógica.


Ejecución del proyecto 🔧
------------------------
Para ejecutar el proyecto, el usuario debe establece como proyecto de inicio el proyecto "Vista" que se encuentra en la carpeta 1.Vista, luego ejecutar la App mediante F5


Ejecutando las pruebas ⚙️
-------------------------
Para ejecutar las pruebas unitarias, el usuario debe ubicarse sobre un método de la clase QueryTest o UpdateTest, dar clic derecho y seleccionar la opción "Depurar pruebas"


Análisis de pruebas end-to-end 🔩
--------------------------------
Para verificar las pruebas unitarias, al ejecutar el método QueryTest que se encuentra en la clase QueryTest, debe retornar un valor entero que identificar el resultado del calculo del query
Para verificar las pruebas de UpdateTest que se encuentra en la clase UpdateTest, la propiedad Points debe tener un valor count mayor a 0 que identifica que la lista esta llena.


Estilo de codificación ⌨️
-------------------------
Personalmente desarrollo este proyecto de tal manera que los atributos pueden ser ubicados mediante un guión bajo y se encuentran privados, estos atributos solo pueden ser accesible de otras clases desde sus propiedades públicas, adicionalmente en este proyecto establezco comentarios tanto de métodos públicos como privados, propiedades y atributos, organizo el código en regiones.


Construido con 🛠️
-----------------
El proyecto fue desarrollado en visual studio .net standard en aplicación de consola.


Autor ✒️
--------
Desarrollado por el ingeniero Freddy Celin