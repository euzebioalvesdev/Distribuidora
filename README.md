# 🧃 Distribuidora de Bebidas • Back-End API

[![.NET](https://img.shields.io/badge/.NET-8.0-blue?logo=dotnet)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)
[![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)]()

Sistema de gerenciamento de uma distribuidora de bebidas — desenvolvido em ASP.NET Core utilizando **Clean Architecture**, com suporte a **AutoMapper**, **Entity Framework**, **Swagger**, entre outros.

---

## 🚀 Funcionalidades

- 📦 CRUD completo de Produtos e Categorias
- 👥 Cadastro de Clientes
- 🧾 Registro de Vendas com múltiplos Itens
- 📊 Integração com Swagger para testes
- 🔄 AutoMapper para mapeamento entre entidades e DTOs
- 🧱 Arquitetura modular com separação clara de responsabilidades
- 📂 Repositórios com EF Core

---
## 🧱 Arquitetura
Distribuidora/
├── Core                # Entidades e Interfaces
├── Application         # Use Cases, DTOs e Mapeamentos
├── Infrastructure      # EF Core, DbContext e Repositórios
├── API                 # Web API com Controllers e Swagger
└── Tests               # Testes futuros 🔧

---

## 🛠️ Tecnologias

- [.NET 8](https://dotnet.microsoft.com/)
- ASP.NET Core Web API
- Entity Framework Core
- AutoMapper
- Swashbuckle / Swagger
- SQL Server (ou outro banco relacional)
- Clean Architecture

---

## 📦 Como rodar localmente

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/DistribuidoraBebidas.git

# Acesse o diretório
cd DistribuidoraBebidas

# Restaure os pacotes
dotnet restore

# Rode a aplicação
dotnet run --project Distribuidora.API
