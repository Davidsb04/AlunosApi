# API ASP.NET CRUD de Alunos

Esta é uma API desenvolvida em ASP.NET para realizar operações CRUD (Create, Read, Update, Delete) em registros de alunos. A API permite que aplicativos cliente interajam com um banco de dados para gerenciar informações sobre alunos.

## Funcionalidades

- **Cadastro de Alunos:** Adicionar novos alunos ao banco de dados.
- **Consulta de Alunos:** Recuperar informações sobre alunos existentes.
- **Atualização de Alunos:** Atualizar os dados de alunos existentes.
- **Remoção de Alunos:** Excluir registros de alunos do banco de dados.

## Endpoints da API

- `GET /api/alunos`: Retorna todos os alunos cadastrados.
- `GET /api/alunos/{id}`: Retorna informações sobre um aluno específico.
- `POST /api/alunos`: Adiciona um novo aluno ao banco de dados.
- `PUT /api/alunos/{id}`: Atualiza informações de um aluno existente.
- `DELETE /api/alunos/{id}`: Remove um aluno do banco de dados.

## Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- MySql WorkBench
- Swagger UI para documentação da API

## Como Executar o Projeto

1. Clone este repositório em sua máquina local.
2. Certifique-se de o APS.NET instalado.
3. Abra o projeto no Visual Studio ou em seu editor de código preferido.
4. Configure a conexão com o banco de dados no arquivo `appsettings.json`.
5. Execute as migrações do Entity Framework Core para criar o banco de dados.
6. Inicie a aplicação e teste os endpoints da API utilizando uma ferramenta como Postman ou Swagger UI.
