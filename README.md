#Gerenciador de tarefas diárias

Este é um aplicativo de gerenciamento de tarefas diárias desenvolvido em .NET 6 usando o projeto Minimal API. 
A aplicação permite que o usuário crie, leia, atualize e delete tarefas, 
além de marcar as tarefas como completas. O aplicativo usa um banco de dados SQLite para armazenar as informações das tarefas.

Executando a aplicação
Para executar a aplicação, você precisa ter o SDK .NET 6 instalado em sua máquina. Você pode baixar o SDK .NET 6 em https://dotnet.microsoft.com/download/dotnet/6.0.

Após a instalação do SDK, você pode executar a aplicação usando o comando abaixo no diretório raiz da aplicação:

> > dotnet run

O aplicativo será executado em localhost por padrão. Você pode acessar a página inicial do Swagger para experimentar as APIs da aplicação em http://localhost:porta/swagger.

Para ver os dados que são adicionados em tempo real, acesse:

http://localhost:porta/v1/todos

Documentação da API com Swagger
A aplicação usa o Swagger para documentar as APIs da aplicação. Você pode acessar a documentação do Swagger em http://localhost:porta/swagger.


A documentação da ainda está em construção, segue abaixo as informações que estão sendo aplicadas:

A lista de endpoints disponíveis na aplicação 
Os verbos HTTP suportados por cada endpoint
Os parâmetros de entrada e saída para cada endpoint
Os códigos de status HTTP que podem ser retornados por cada endpoint
Você pode experimentar as APIs diretamente da página do Swagger. Para fazer isso, clique em um endpoint e, em seguida, clique no botão "Try it out" para abrir a seção de entrada de parâmetros. Insira os parâmetros desejados e clique em "Execute" para enviar a solicitação. A resposta será exibida na seção "Response body".
