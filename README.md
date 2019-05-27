# plataforma-reeduca

Este projeto é Api backend que faz a chamada ao banco de dados MongoDB e retorna as solicitações para o cliente.

- Api.Reduca
Esta Api recebe e retorna as requisições para o cliente. Faz a chamada no repository que busca os dados no mongoDB e retorna a resposta para o cliente.

- Api.Reduca.Model
Contém as classes as entidades do projeto

- Api.Reduca.Repository
Contem as cnonfigurações de acesso a dados, camada de banco

# Ambiente

ASP.Net Core 2.1
MongoDB 2.8.1.0
C#

Para rodar o projeto é preciso ter instalado a IDE Visual Studio 2017/2019 ou VSCode

- Padrões
Os projetos devem seguir as diretivas abaixo:

1. Nomes de classes devem ser escritas em português
2. Classes e propriedades devem conter a documentação ex:  
/// <summary>
/// Entidade usuário
/// </summary>
public class Usuario

/// <summary>
/// Nome do usuário
/// </summary>
public string Nome { get; set; }

3. Nomes de variáveis devem começar com letra minúscula e métodos com letra maiúscula
4. Utilizar os conceitos de BDD e SOLID, reaproveitamento de código e extensão, justificar bem a criação de Interfaces
5. Comentários no código apenas se necessário
6. Todo commit deve ser justificado ex: Criação das classes X que faz tal coisa
7. Sempre que fo adicionado um método no Repository, adicione tratamento de erro conforme log

    

