# 🎯 Roller Smart Cart - Backend (.NET Core API)

This is the backend API for the **Roller Smart Cart** system — a modern, intelligent shopping solution integrating object detection, real-time communication, and seamless checkout.

> 🧑‍🎓 This project was developed as part of my **graduation project**.
> 
## 🚀 Technologies Used

- **ASP.NET Core Web API (.NET 7)**
- **Entity Framework Core** (Code-First & Migrations)
- **SQL Server** for data persistence
- **JWT Authentication** with role-based access control
- **SignalR** for real-time cart updates
- **Stripe API** for secure payment processing


## 🧠 Key Features

- 🔐 **Secure Authentication System**  
  - JWT-based login and registration  
  - Admin and User roles

- 🛒 **Smart Cart Functionality**  
  - Product detection via Raspberry Pi + YOLOv11n model  
  - Weight sensor validation  
  - OCR fallback for detection errors

- 📦 **Product & Category Management**  
  - CRUD operations  
  - Soft delete & restore  
  - Offer management (add/remove discounts)

- ⚙️ **Order Management**  
  - Create, update and retrieve user orders  
  - Associate products with orders  
  - Track order activity

- 🧾 **Real-Time Communication**  
  - SignalR to sync cart updates with frontend in real time  
  - User prompt and feedback in case of detection issues

- 💳 **Stripe Checkout Integration**  
  - Session creation and payment tracking  
  - Clean integration without exposing secrets

- 🛡️ **Admin Tools**  
  - Lock/unlock users  
  - View user data, order logs and system activity

## 📁 Project Structure

- `SmartCart.Application` – Business logic & service interfaces  
- `SmartCart.Domain` – Core models & domain logic  
- `SmartCart.Infrastructure` – DB context, repositories, integrations  
- `SmartCart` – API endpoints and controllers

### 📌 Note:
This backend is part of the **Roller Smart Cart** system and is designed to integrate with a frontend Angular client available [here](https://github.com/MennaMabrouk/Roller-Smart-Cart-Client). However, all backend APIs can be tested independently via tools like Postman or Swagger.

