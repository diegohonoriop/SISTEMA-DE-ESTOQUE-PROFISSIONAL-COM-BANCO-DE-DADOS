# 🌐 Web API de Gerenciamento de Estoque Profissional

Uma Web API moderna construída para o gerenciamento e inventário de peças automotivas. O projeto demonstra a evolução do sistema de console para uma aplicação Web completa que expõe dados estruturados e realiza persistência real.

## 🛠️ Tecnologias e Ferramentas Utilizadas
*   **Back-end:** C# e ASP.NET Core (Arquitetura de Minimal APIs)
*   **Banco de Dados:** SQLite (Armazenamento em arquivo local integrado)
*   **Mapeamento Objeto-Relacional (ORM):** Entity Framework Core (EF Core)
*   **Formatos:** JSON (JavaScript Object Notation) para tráfego e comunicação de dados

## 🎯 Arquitetura de Rotas e Endpoints Criados
O servidor mapeia requisições HTTP e entrega respostas dinâmicas processadas a partir do banco de dados:

*   `GET /` -> Rota inicial de boas-vindas ao sistema.
*   `GET /status` -> Endpoint de verificação de integridade do servidor (*Health Check*).
*   `GET /oficina` -> Retorna as informações corporativas e localização do estabelecimento.
*   `GET /produtos` -> **Integração com Banco de Dados:** Consulta a tabela do SQLite via EF Core e retorna a listagem completa de produtos cadastrados em formato JSON nativo para o navegador.

## ⚙️ Diferenciais Técnicos Implementados
*   **Criação Automática do Banco:** Utilização do comando `EnsureCreated()` para verificar e criar a estrutura de tabelas dinamicamente na inicialização.
*   **Dados Iniciais (Data Seeding):** O sistema verifica se o estoque está vazio e popula o banco automaticamente com itens de teste para validação imediata da API.

---
*Projeto desenvolvido por Diego de Souza para consolidação de arquitetura Web Back-end e persistência de dados.*
