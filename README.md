# Lista de Tarefas

Projeto desenvolvido para estudo e demonstração de um fluxo profissional de desenvolvimento de software.

O projeto consiste em uma **lista de tarefas**, na qual cada usuário possui suas próprias tarefas e pode gerenciá-las após realizar o login.

## Funcionamento

Ao iniciar a aplicação, o usuário pode:

1. Criar uma nova conta;
2. Fazer login em uma conta existente;
3. Visualizar suas tarefas cadastradas;
4. Filtrar e ordenar as tarefas por diferentes parâmetros;
5. Criar novas tarefas;
6. Editar tarefas existentes;
7. Excluir tarefas.

Entre os parâmetros disponíveis para filtragem e ordenação estão:

* Data de inclusão;
* Data de expiração;
* Prioridade;
* Status;
* Ordem alfabética;
* Outros parâmetros relevantes.

## Conceitos Explorados

O projeto tem como objetivo explorar diferentes conceitos e tecnologias utilizados no desenvolvimento de aplicações web com .NET.

### Autenticação e Autorização

O cadastro e o login dos usuários permitem trabalhar conceitos relacionados a:

* Autenticação;
* Autorização;
* Controle de acesso;
* Gerenciamento de usuários.

### CRUD

O gerenciamento das tarefas permite explorar as operações básicas de um CRUD:

* **Create** — Criar tarefas;
* **Read** — Consultar tarefas;
* **Update** — Atualizar tarefas;
* **Delete** — Excluir tarefas.

### LINQ

Utilização de **LINQ** para consulta, filtragem, ordenação e manipulação dos dados.

### Entity Framework

Utilização do **Entity Framework Core** para:

* Mapeamento objeto-relacional (ORM);
* Acesso ao banco de dados;
* Persistência dos dados;
* Criação e gerenciamento de migrations.

### Arquitetura em Camadas

O projeto utiliza uma arquitetura organizada em diferentes responsabilidades:

* **Controller** — Responsável por receber e responder às requisições HTTP;
* **Service** — Responsável pelas regras de negócio;
* **Repository** — Responsável pelo acesso e persistência dos dados.

### Validações e Rate Limiting

Implementação de mecanismos para:

* Validação de dados recebidos pela API;
* Tratamento de entradas inválidas;
* Controle da quantidade de requisições realizadas pelos clientes através de **Rate Limiting**.

### Docker

Utilização de **Docker** para containerização da aplicação e de seus serviços.

### CI/CD

Configuração de um fluxo de **CI/CD** utilizando **GitHub Actions**, contemplando etapas como:

* Build;
* Testes;
* Validação da aplicação;
* Criação de artefatos;
* Deploy.

## Tecnologias

* C#
* .NET / ASP.NET Core
* Entity Framework Core
* Banco de dados relacional Postgres
* Docker
* Git
* GitHub
* GitHub Actions

## Objetivo

Além de desenvolver uma aplicação funcional, o projeto tem como objetivo demonstrar conhecimentos relacionados a:

* Desenvolvimento de APIs;
* Arquitetura de software;
* Banco de dados;
* Boas práticas de programação;
* Git e GitHub;
* Automação de processos;
* CI/CD;
* Containerização;
* Deploy.
