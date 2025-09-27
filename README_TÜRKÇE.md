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
## 🧩 Mikroservis Genel Görünümü

### 📦 Catalog Mikroservisi

- C# 12 kullanarak ASP.NET Core 8 Minimal API'ler
- Vertical Slice Mimarisi ve Özellik (Feature) Klasörleri ile yapılandırma
- MediatR ile CQRS (Komut-Sorgu Sorumluluk Ayrımı) uygulaması
- PostgreSQL üzerinde Marten ile Belge Tabanlı (Document DB) veri yönetimi
- API uç noktalarının tanımı için Carter kütüphanesi
- Loglama, Sağlık Kontrolleri ve Global Hata Yakalama (Exception Handling)

### 🧺 Basket Mikroservisi

- ASP.NET Core 8 Web API ile RESTful servisler
- Redis ile dağıtık önbellek (distributed cache) kullanımı
- Proxy, Decorator ve Cache-aside tasarım desenlerinin uygulanması
- Ürün indirimi hesaplamak için gRPC üzerinden Discount servisini senkron olarak çağırma
- Sepet onayı (BasketCheckout) olayını MassTransit ve RabbitMQ kullanarak yayınlama

### 🎁 Discount Mikroservisi

- Yüksek performanslı ASP.NET Core gRPC sunucusu
- SQLite + EF Core ORM ile veritabanı işlemleri ve migration’lar
- gRPC için Protobuf tabanlı mesaj tanımları

### 🧾 Order Mikroservisi 

- DDD (Domain-Driven Design), CQRS ve Temiz Mimari (Clean Architecture) prensipleri ile geliştirilmiş
- Domain Olayları (Domain Events) ve Entegrasyon Olayları (Integration Events) kullanımı
- EF Core Code-First yaklaşımı ile SQL Server üzerinde veritabanı işlemleri
- RabbitMQ üzerinden gelen BasketCheckout olaylarını dinleyerek sipariş sürecini başlatma

### 🚪 API Gateway

- YARP (Yet Another Reverse Proxy) ile oluşturulmuş API Geçidi
- Gateway Routing Pattern (Geçit Yönlendirme Deseni) uygulanması
- Route (Yönlendirme), Cluster (Kümeleme), Path (Yol), Transform (Dönüştürme), Destinations (Hedefler) yapılandırmaları
- Sabit Zaman Penceresi sınırlaması (FixedWindowLimiter) ile Rate Limiting uygulaması

### 🛍️ WebUI

- Bootstrap 4 ve Razor Pages ile ASP.NET Core MVC Web Uygulaması
- Refit ve HttpClientFactory kullanarak API Gateway üzerinden mikroservislere erişim
- Razor bileşenleri: View Components, TagHelpers, Model Binding, Validations
