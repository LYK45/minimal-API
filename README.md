# minimal-API
Projeto Avanade de entity framework

🚗 API de Cadastro de Veículos
API RESTful desenvolvida em ASP.NET Core como parte de um desafio prático do bootcamp Avanade | DIO - Backend com .NET e IA.

📝 Visão Geral do Projeto
Este projeto representa um dos desafios propostos no bootcamp , uma parceria entre a  e a .

O objetivo foi construir o backend de um sistema projetado para permitir que usuários registrem e gerenciem seus veículos. A API oferece endpoints para as operações de CRUD (Criar, Ler, Atualizar, Deletar) e implementa um sistema de permissões baseado em dois níveis de acesso: Usuário Padrão e Administrador, garantindo que os dados sejam acessados e manipulados de forma segura.

✨ Principais Funcionalidades
O sistema possui dois níveis de acesso com funcionalidades distintas:

Para Usuários Padrão (User)
Cadastro de Veículos: Adicionar novos veículos à sua conta pessoal.

Consulta de Veículos: Visualizar a lista completa de veículos registrados em seu nome.

Detalhes do Veículo: Acessar informações específicas de um dos seus veículos.

Contagem de Veículos: Obter o número total de veículos que possui cadastrado.

Para Administradores (Admin)
Acesso Total: Possui todas as permissões de um usuário padrão.

Gerenciamento Global: Pode visualizar, editar e deletar o cadastro de qualquer veículo no sistema.

Supervisão Completa: Tem liberdade para acessar todos os dados registrados na plataforma.

💻 Tecnologias Utilizadas
Backend: ASP.NET Core

Banco de Dados: Microsoft SQL Server

ORM (Object-Relational Mapper): Entity Framework Core

Arquitetura: Web API RESTful

👨‍💻 Autor
[LUCAS OLIVEIRA]

