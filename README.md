# 📦 EShopMicroservicesProject Documentation

## 📌 Overview

**EShopMicroservicesProject** is an e-commerce application developed using the C# programming language and built on a **[microservices architecture](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/MicroserviceArchitecture.md)**. The project provides a modular structure, aiming to enable each component to be developed and managed independently. The presence of Dockerfiles indicates that the application supports container-based deployment.

---

## 🏛️ Architectures

- **[Layered Architecture](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/LayeredArchitecture.md)**
- **[Domain Driven Design (DDD)](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/DomainDrivenDesign.md)**
- **[Vertical Slice Architecture](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/VerticalSliceArchitecture.md)**
- **[Clean Architecture](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/CleanArchitecture.md)**

---

## 🧩 Design Principles and Patterns

- **[SOLID Principles](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/SOLIDPrinciples.md)**
- **[CQRS (Command Query Responsibility Segregation)](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/CQRS.md)**
- **[MediatR Pattern](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/MediatRPattern.md)**
- **[Decorator Pattern](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/DecoratorPattern.md)**
- **[Option Pattern](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/OptionPattern.md)**
- **[API Gateway](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/ENGLISH/APIGateway.md)**

---

## 🗄️ Databases

- **Transactional Document Database**
- **PostgreSQL**
- **Redis**
- **SQLite**
- **Microsoft SQL Server (MSSQL)**

---

## 📚 Libraries and Tools

- **Carter** – Routing library for building minimal APIs  
- **Marten** – Document store and event sourcing for .NET with PostgreSQL  
- **MediatR** – In-process messaging and decoupling  
- **Mapster** – Object mapping library  
- **MassTransit** – Distributed messaging framework (commonly used with RabbitMQ)  
- **FluentValidation** – Model validation framework  
- **Entity Framework Core (EF Core)** – ORM for .NET  
- **Refit** – Type-safe REST API client  

---

## 🔌 Communication Methods

### Synchronous (Sync)

- **gRPC**

### Asynchronous (Async)

- **Publish-Subscribe Pattern** – Using MassTransit with RabbitMQ

### YARP API Gateway
---
