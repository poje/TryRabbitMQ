// See https://aka.ms/new-console-template for more information
using System.Text;
using RabbitMQ.Client;

Console.WriteLine("Hello, World!");

var factory = new ConnectionFactory() { HostName = "localhost" };

using(var connection = factory.CreateConnection())
{
    //Creamos un canal
    using (var channel = connection.CreateModel())
    {
        //Creamos una cola a donde irán los mensajes
        //Si no encuentra la cola, la crea
        channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

        string message = "Hola mundo";

        var body = Encoding.UTF8.GetBytes(message);

        channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);

        Console.WriteLine($"[x] Sent {message}");

    }

    Console.WriteLine("Press any key to exit...");
    Console.ReadLine();
}