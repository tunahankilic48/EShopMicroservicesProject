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

---

## 🧩 Microservices Overview

### 📦 Catalog Microservice

- ASP.NET Core 8 Minimal APIs using C# 12
- Vertical Slice Architecture & Feature Folders
- CQRS with MediatR
- Marten for PostgreSQL Document DB
- Carter for API endpoint definitions
- Logging, Health Checks, Global Exception Handling

### 🧺 Basket Microservice

- RESTful APIs with ASP.NET Core 8 Web API
- Redis as distributed cache
- Proxy, Decorator, Cache-aside design patterns
- gRPC client for Discount service
- Publishes checkout events to RabbitMQ using MassTransit

### 🎁 Discount Microservice

- High-performance gRPC service with ASP.NET Core
- SQLite + EF Core ORM with migrations
- Protobuf-based message contracts for gRPC

### 🧾 Ordering Microservice

- Implements DDD, CQRS, Clean Architecture
- Domain Events, Integration Events
- SQL Server with EF Core Code-First
- Subscribes to checkout events via RabbitMQ

### 🚪 API Gateway

- Built with YARP (Yet Another Reverse Proxy)
- Gateway Routing Pattern
- Route clustering, transforms, and rate limiting

### 🛍️ WebUI (ShoppingApp)

- ASP.NET Core MVC (Razor Pages, Bootstrap 4)
- Refit with HttpClientFactory for API communication
- Razor components: View Components, TagHelpers, Model Binding, Validations

---

