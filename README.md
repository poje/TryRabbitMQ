# TryRabbitMQ
Prueba de concepto de RabbitMQ para implementación de colas

#### Debemos inicializar docker (en caso de no tenerlo instalado, deben instalar docker desktop) o instalar el instalador de RabbitMQ para Windows en su defecto

En caso de usar Docker, en la consola, correr el siguiente comando:
```pwsh
docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.11-management
```
con este comando vamos a crear un contenedor que va a mantener ejecutando el servidor de RabbitMQ al cual nos conectaremos con las aplicaciones.

Después:
1. Clonar el proyecto
2. Abrir ambos proyectos en ventanas diferentes de Visual Studio Code
3. Darle run a las soluciones (primero a la Receive y después a la Send) via consola con el comando:
```pwsh
  dotnet run
```
4. en ambas consolas debería mostrarse el mensaje de hola mundo como en la imagen siguiente
![image](https://user-images.githubusercontent.com/581483/236926237-5dc98c3d-327c-4ba0-b632-24fab6aae9c3.png)

Cosas que he notado viendo el video mientras lo hacía (en primera instancia):
- Podemos crear distintos nodos de RabbitMQ (es decir, podemos tener varias instancias de RabbitMQ corriendo en paralelo, me imagino que más instancias, más maquinas dedicadas..)
- Podemos crear diferentes canales (Channels 🛰️)
- Dentro de cada canal podemos crear muchas colas (queue 📡), con diferentes nombres.
- al momento de recibir los mensajes, podemos recibirlo desde el canal que especifiquemos
- me imagino que en este punto, dependiendo del mensaje que vayamos recibiendo, podemos ir realizando acciones sobre ciertas cosas a nivel de base de datos o aplicaciones


## En Construcción... 👨‍🏭👷‍♂️
