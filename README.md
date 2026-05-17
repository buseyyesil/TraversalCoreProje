🌍 Traversal Travel Reservation System
<p align="center">
  <img src="https://img.shields.io/badge/.NET-6.0-512BD4?style=for-the-badge&logo=dotnet"/>
  <img src="https://img.shields.io/badge/ASP.NET_Core-MVC-blue?style=for-the-badge&logo=microsoft"/>
  <img src="https://img.shields.io/badge/Entity_Framework-Core-purple?style=for-the-badge"/>
  <img src="https://img.shields.io/badge/SignalR-Real_Time-red?style=for-the-badge"/>
  <img src="https://img.shields.io/badge/MSSQL-Server-CC2927?style=for-the-badge&logo=microsoftsqlserver"/>
  <img src="https://img.shields.io/badge/PostgreSQL-336791?style=for-the-badge&logo=postgresql&logoColor=white"/>
</p>
---
📌 About The Project
Traversal is a comprehensive travel reservation management system built with ASP.NET Core 6 MVC architecture, implementing modern software design patterns including CQRS, MediatR, Generic Repository, and Unit of Work patterns for enterprise-level application development.
> 🎓 Developed under the guidance of **Erhan Gündüz** at M&Y Software Education Academy.
---
🖼️ Screenshots
🏠 Homepage
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160448.png" alt="Homepage" width="100%"/>
</p>
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160522.png" alt="Homepage Slider" width="100%"/>
</p>
✈️ Destination List
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160546.png" alt="Destinations" width="100%"/>
</p>
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160556.png" alt="Destinations 2" width="100%"/>
</p>
🗺️ Tour Routes Gallery
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160609.png" alt="Tour Routes Gallery" width="100%"/>
</p>
💬 Testimonials & Footer
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160642.png" alt="Testimonials" width="100%"/>
</p>
👤 Member Panel - Latest Routes
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160720.png" alt="Member Panel Latest Routes" width="100%"/>
</p>
📖 Guide Detail Page
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160823.png" alt="Guide Detail" width="100%"/>
</p>
💬 Comments Section
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160838.png" alt="Comments" width="100%"/>
</p>
📝 Register Page
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_160851.png" alt="Register" width="100%"/>
</p>
🔐 Login Page
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_161312.png" alt="Login" width="100%"/>
</p>
🗺️ Member Panel - Tour Routes
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_161335.png" alt="Member Panel Tour Routes" width="100%"/>
</p>
📅 Member Panel - Active Reservations
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_161517.png" alt="Active Reservations" width="100%"/>
</p>
<p align="center">
  <img src="screenshots/Ekran_g%C3%B6r%C3%BCnt%C3%BCs%C3%BC_2026-05-17_161538.png" alt="Active Reservations Detail" width="100%"/>
</p>
---
🏗️ Architecture & Design Patterns
Pattern	Description
CQRS	Separation of read and write operations
MediatR	Request/Response pipeline management
Generic Repository	Data access layer abstraction
Unit of Work	Transaction integrity management
Dependency Injection	IoC Container for dependency management
ViewComponent	Modular and reusable UI components
---
📁 Project Layers
```
TraversalCoreProje/
│
├── 📦 EntityLayer/                  → Domain models and database schema
│   └── Concrete/                   → About, Destination, Guide, Reservation, etc.
│
├── 📦 DataAccessLayer/              → Data access layer
│   ├── Abstract/                   → Interfaces (IGenericDal, IDestinationDal, etc.)
│   ├── Concrete/                   → EF Core Context
│   ├── EntityFramework/            → Repository implementations
│   ├── Repository/                 → GenericRepository, GenericUowRepository
│   └── UnitOfWork/                 → IUowDal, UowDal
│
├── 📦 BusinessLayer/                → Business logic layer
│   ├── Abstract/                   → Service interfaces
│   ├── Concrete/                   → Manager classes
│   ├── Container/                  → DI Extensions
│   └── ValidationRules/            → FluentValidation rules
│
├── 📦 DTOLayer/                     → Data transfer objects
│   └── DTOs/                       → AnnouncementDTO, AppUserDTO, etc.
│
├── 📦 SignalRApi/                   → PostgreSQL-based SignalR API
│   ├── DAL/                        → Context, Visitor
│   ├── Hubs/                       → VisitorHub
│   └── Model/                      → VisitorService, VisitorChart
│
├── 📦 SignalRApiForSql/             → SQL Server-based SignalR API
│   ├── DAL/                        → Context, Visitor
│   ├── Hubs/                       → VisitorHub
│   └── Models/                     → VisitorService, VisitorChart
│
├── 📦 SignalRConsume/               → SignalR MVC client
│   └── Views/Home/                 → Index, Index2, Index3
│
└── 📦 TraversalCoreProje/           → Main MVC project
    ├── Areas/
    │   ├── Admin/                  → Admin management panel
    │   └── Member/                 → Member panel
    ├── CQRS/
    │   ├── Commands/               → Destination & Guide commands
    │   ├── Handlers/               → Command & Query handlers
    │   ├── Queries/                → Query classes
    │   └── Results/                → Result models
    ├── Controllers/                → Main controllers
    ├── Mapping/                    → AutoMapper profiles
    ├── Models/                     → ViewModels
    └── ViewComponents/             → Modular UI components
```
---
🔹 Features
🛡️ Admin Panel
✅ Destination management (CRUD)
✅ Guide management (CRUD + Active/Inactive)
✅ Announcement management (AutoMapper + FluentValidation)
✅ User and role management (Identity)
✅ Comment management and moderation
✅ Contact message management
✅ Bank transfer (Unit of Work Pattern)
✅ CQRS-based Destination module
✅ MediatR-based Guide module
👤 Member Panel
✅ Registration & Login (ASP.NET Core Identity)
✅ Profile editing & photo upload
✅ Password update
✅ Reservation creation
✅ Reservation tracking (Waiting / Approved / Past)
✅ Destination comment adding and listing
✅ Destination search (name-based filtering)
📊 SignalR Real-Time Statistics
✅ PostgreSQL + crosstab query for pivot data
✅ SQL Server + PIVOT query for pivot data
✅ Google Charts Line and Column Chart visualization
✅ Real-time updates via WebSocket connection
📄 Reporting
✅ EPPlus for static Excel reports
✅ ClosedXML for dynamic Excel reports
✅ iTextSharp for paragraph-based PDF reports
✅ iTextSharp for table-based PDF reports
🌐 API Integrations
✅ Booking.com API → Hotel search and listing
✅ Booking.com API → TRY-based exchange rates
✅ IMDB Top 100 API → Movie list
📧 Other Features
✅ MailKit for SMTP email sending
✅ Newsletter subscription system
✅ Custom 404 error page
✅ ViewComponent architecture for modular UI
---
🔧 Technologies Used
Technology	Version	Purpose
ASP.NET Core MVC	6.0	Web framework
Entity Framework Core	6.0	ORM
ASP.NET Core Identity	6.0	Authentication
SignalR	6.0	Real-time communication
MediatR	11.0	CQRS pipeline
AutoMapper	12.0	Object mapping
FluentValidation	11.3	Form validation
ClosedXML	0.105	Excel reporting
EPPlus	6.0	Excel reporting
iTextSharp	LGPLv2	PDF reporting
MailKit	4.0	Email sending
Newtonsoft.Json	-	JSON processing
Bootstrap	5	UI framework
Google Charts	-	Chart visualization
MSSQL Server	-	Main database
PostgreSQL	-	SignalR database
---
