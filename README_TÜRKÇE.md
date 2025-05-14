# 📦 EShopMicroservicesProject Dökümantasyonu

## 📌 Genel Bakış

**EShopMicroservicesProject**, C# dili kullanılarak geliştirilen ve [mikroservis mimarisi](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/MikroservisMimarisi.md) üzerine kurulu bir e-ticaret uygulamasıdır. Proje, modüler bir yapı sunarak her bir bileşenin bağımsız olarak geliştirilmesini ve yönetilmesini hedeflemektedir. Dockerfile dosyalarının varlığı, uygulamanın konteyner tabanlı dağıtımını desteklediğini göstermektedir.

---

## 🏛️ Kullanılan Mimariler

- **[Katmanlı Miamari (Layered Architecture)](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/KatmanliMimari.md)**
- **[Domain Driven Design (DDD)](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/DomainDrivenDesign.md)**
- **[Vertical Slice Architecture](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/VerticalSliceArchitecture.md)**
- **[Clean Architecture](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/CleanArchitecture.md)**

---

## 🧩 Tasarım İlkeleri ve Pattern'ler

- **[SOLID Prensipleri](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/SOLIDPrensipleri.md)**
- **[CQRS (Command Query Responsibility Segregation)](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/CQRS.md)**
- **[MediatR Pattern](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/MediatRPattern.md)**
- **[Decorator Pattern](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/DecoratorPattern.md)**
- **[Option Pattern](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/OptionPattern.md)**
- **[API Gateway](https://github.com/tunahankilic48/DICTIONARY-SOZLUK/blob/main/T%C3%9CRK%C3%87E/APIGateway.md)**

---

## 🗄️ Kullanılan Veritabanları

- **Transactional Document Database**
- **PostgreSQL**
- **Redis**
- **SQLite**
- **Microsoft SQL Server (MSSQL)**

---

## 📚 Kullanılan Kütüphaneler ve Araçlar

- **Carter** – Minimal API yapısı için routing kütüphanesi  
- **Marten** – PostgreSQL tabanlı .NET için document store ve event sourcing desteği  
- **MediatR** – Uygulama içi mesajlaşma ve gevşek bağlılık için  
- **Mapster** – Nesne eşleştirme (object mapping) aracı  
- **MassTransit** – Dağıtık mesajlaşma için kütüphane (özellikle RabbitMQ ile)  
- **FluentValidation** – Model doğrulama işlemleri için  
- **Entity Framework Core (EF Core)** – ORM aracı  
- **Refit** – Tip güvenli REST API istemcisi  

---

## 🔌 İletişim Yöntemleri

### Senkron (Sync)

- **gRPC**

### Asenkron (Async)

- **Publish-Subscribe Pattern** – MassTransit ile RabbitMQ kullanılarak

### YARP API Gateway

---
