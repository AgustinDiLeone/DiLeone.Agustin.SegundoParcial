# CRUD - Dispositivos electronicos
## Alumno: Agustin Di Leone
Yo soy Agustin Di Leone, tengo 19 años y vivo en Lanus, Buenos Aires. Estoy cursando la carrera Tecnico en Programacion en la Universidad Tecnologica Nacional en Avellaneda.
Este proyecto fue creado por mi persona, como entrega del primer parcial de Lboratorio II. Trate de implementar todos los conocimientos adquiridos durante la primer parte de 
dicha materia junto a Prgramacion II que van de la mano.
## Programa CRUD
La aplicacion que programe sirve para el ingreso de distintos clientes los cuales son registrados por nombre, cuit, que tipo de clientes son y donde se ubican, los cuales
contienen una listas de distintos dispositivos que compraron. Estos pueden ser celulares, notebooks y/o televisores. 
La aplicacion premite:
### Log In:
El ingreso de ciertos usuarios pidiendo correo y contraseña, verificandolo con el uso de un archivo .json, que contiene los usuarios autorizados a modo de base de datos. 
### Usuario Ingresado:
En los Winddows Form siempre esta la posibilidad de ver que usuario es el que esta ejecutando el programa con el horario de inicio de sesion. Ademas de poder visualizar
todos los inicios de sesion, detallando usuario y hora, almacenandolo en un archivo .log.
### Clientes:
Un Windows Form que contiene todos los clientes de la empresa. Un CRUD el cual permite agregar, modificar, ver y eliminar dichos clientes. Ademas de la posibilidad de oredenarlos
en el visor por medio de su nombre o cuit, ya sea de forma ascendente o descendiente.
### Dispositivos Electronicos:
Cuando seleccionas la opcion Ver de algun cliente, podes visualizar otro CRUD de los dispositivos adqueridos por dicho cliente. Estos dispositivos pueden ser del tipo celular, notebook
y/o televisor. A tener un CRUD, tambien se pueden ver, agregar, modificar o eliminar dichos aparatos. Tambien cuenta con la posibilida de ordenarlos usando ID o la MARCA, de manera 
ascendente o descendente, segun se elija.
### Resguardo de datos:
La lista de clientes, los cuales incluyen sos dispositivos adqueridos, estan almacenados en una archivo .xml. Este se deserializa cuando se inicia cuando se ingresa correctamente el usuario y se serializa cuando se cierra la aplicacion.
### BackUp:
Se agrega la funcion de back up de la lista de los clientes. Con todas las funcionalidades del CRUD, permite resguardar los datos en una base de dato SQL. Ademas se agrego un boton "BackUp SQL" el cual permite visualizar los datos guardados en la base de datos. 
### Test Unitarios
Contiene un proyecto de tipo Test donde se diseñaron algunos metodos para probar el correcto funcionamiento de la aplicacion.
### Task
Esta aplicacion tiene una programacion multihilo, mostrandote la fecha y hora actual en la parte inferior izquierda, en un hilo secundario, para que no afecte la agilidad de la aplicacion.
### Eventos
Mediante el uso de eventos propios: 
* Presionando la tecla "esc" se cierra los formularios principales.
* Se lanza un evento cuando se confirme que exitosamente se ha hecho una cracion, modificacion o eliminacion de algun cliente o producto. Mostrandolo mediante un MessageBox la tarea realizada.
## Diagrama de clase
![ClassDiagram](https://github.com/AgustinDiLeone/DiLeone.Agustin.PrimerParcial/assets/123491937/94f88e1c-271f-4e7c-aded-86a648c4cddf)
