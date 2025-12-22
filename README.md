# Orquestra API – Pedidos

## Descrição

Este repositório contém um **projeto base em .NET** estruturado segundo os princípios de **Clean Architecture**, com foco em **Domain-Driven Design (DDD)**.  
O objetivo é servir como um **modelo inicial reutilizável**, com configurações essenciais já prontas.

A proposta do projeto é fornecer uma base arquitetural organizada, desacoplada e preparada para evolução, não sendo um produto final.

---

## Conceitos Aplicados

- Clean Architecture  
- Domain-Driven Design (DDD)  
- Separação clara de responsabilidades  
- Domínio independente de infraestrutura  
- Uso de **DTOs na camada Infrastructure** para desacoplamento de bancos de dados externos  

---

## Estrutura da Solução

- **Domain**: Entidades e contratos, sem dependências externas  
- **Application**: Casos de uso e orquestração  
- **Infrastructure**: Integrações, DTOs e acesso a dados externos  
- **API**: Exposição dos endpoints e Swagger  

---

## Observações

- Conexão com banco de dados já configurada  
- Métodos de negócio intencionalmente incompletos  
- Projeto criado como **base arquitetural e referência**

---
