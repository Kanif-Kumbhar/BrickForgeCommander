# 🧱 BrickForge Commander

**Comprehensive Production Management System for Brickyard Operations**

> *A desktop application designed to revolutionize brick manufacturing management through comprehensive automation and intelligent tracking systems.*

---

## 📋 Overview

BrickForge Commander is an enterprise-grade desktop management system specifically designed for brick manufacturing facilities. This comprehensive solution streamlines the entire brick production lifecycle—from raw material procurement to final product delivery—eliminating manual paperwork, reducing errors, and enabling real-time visibility across all operational stages.

### The Problem

Traditional brickyard management faces critical challenges:

* **Time-Consuming Processes** - Manual record-keeping leads to delays and inefficiency
* **Poor Communication** - Inadequate coordination between departments causes errors
* **Labour-Intensive Operations** - Heavy reliance on manual labour for inventory and tracking
* **Manual Data Entry Errors** - Cumbersome paper-based processes prone to inaccuracies
* **Worker Fraud** - Instances of payment fraud and unauthorized absences
* **Document Loss** - Physical registers susceptible to misplacement or damage

### The Solution

BrickForge Commander delivers a comprehensive automated management platform that provides:

* 📊 **Real-time Dashboard** - Live statistics on stock, sales, and production performance
* 🔒 **Secure Data Management** - Centralized SQL Server database with role-based access
* 📈 **Automated Reporting** - Instant generation of sales, inventory, and financial reports
* 💰 **Complete Financial Tracking** - GST calculations, profit margins, and payment management
* 🚚 **Delivery Management** - Vehicle and driver assignment with route optimization
* 👷 **Worker Management** - Attendance, productivity tracking, and automated wage calculation

---

## ✨ Key Features

### Production Management

* **Raw Material Tracking** - Monitor stock levels of soil, coal, lime, sand, and other materials
* **Automated Stock Alerts** - Understock/overstock notifications with visual indicators
* **Batch Management** - Track production batches from mixture preparation to firing
* **Product Classification** - Multiple brick types with customizable specifications
* **Quality Control** - Track production rates, defects, and worker performance

### Inventory Control

* **Real-time Stock Updates** - Automatic inventory adjustments based on production and sales
* **Multi-location Storage** - Track raw materials and finished goods across multiple locations
* **Storage Capacity Management** - Monitor utilization and optimize space allocation
* **Product Dictionary** - Comprehensive catalog with specifications and pricing
* **Stock Status Reporting** - Visual indicators for overstocked, normal, and understocked items

### Worker & Labor Management

* **Worker Registration** - Complete profiles with personal details, roles, and batch assignments
* **Batch Assignment** - Organize workers into production batches for better coordination
* **Task-based Pricing** - Configure rates for Making (mixture), Dhulai (moulding), and Nikashi (removal)
* **Automated Wage Calculation** - Calculate earnings based on actual work performed
* **Worker Ledger** - Track payments, loans, and repayments with due date management
* **Productivity Analytics** - Monitor individual and team production metrics

### Sales & Order Management

* **Customer Registration** - Maintain comprehensive customer database with contact details
* **Order Processing** - Create, track, and fulfill customer orders efficiently
* **Multi-stage Order Tracking** - Monitor orders through In-Queue, Dispatched, Delivered, and Cancelled stages
* **Invoice Generation** - Automated GST-compliant billing with customizable templates
* **Payment Processing** - Support for cash and online payments with balance tracking
* **Discount Management** - Flexible discount percentage application

### Delivery & Logistics

* **Vehicle Management** - Register trucks, dumpers, and other vehicles with load capacity tracking
* **Driver Assignment** - Assign drivers to vehicles and orders with license verification
* **Delivery Cost Configuration** - Set city-wise delivery charges (bhada) per trip
* **Route Optimization** - Track delivery assignments and optimize transportation costs
* **Insurance Tracking** - Monitor vehicle insurance expiry dates

### Financial Management

* **GST Calculations** - Automatic 12% GST computation and reporting
* **Profit Margin Analysis** - Track profit margins per product and order
* **Payment Tracking** - Monitor due dates, pending payments, and loan amounts
* **Expense Management** - Record raw material purchases and operational costs
* **Revenue Reports** - Daily, weekly, and monthly revenue visualization
* **Credit Score System** - Track customer creditworthiness

### Supplier Management

* **Supplier Registration** - Maintain supplier database with contact information
* **Purchase Order Management** - Create and track raw material orders
* **Payment Terms** - Support for cash and credit payments with due date tracking
* **Supplier Performance** - Monitor delivery times and material quality
* **Bill Management** - Record and track supplier bills and payments

### Reporting & Analytics

* **Dashboard Analytics** - Real-time KPIs including orders, revenue, and stock levels
* **Worker Reports** - Work history, payment records, and productivity metrics
* **Stock Reports** - Raw material and product inventory status
* **Order Reports** - Complete order history with payment status
* **GST Reports** - Tax-compliant reports for regulatory compliance
* **Profit Analysis** - Visual charts showing daily, weekly, and monthly profits
* **Driver & Vehicle Reports** - Comprehensive fleet and driver information

---

## 🚀 Getting Started

### Prerequisites

**Hardware Requirements**:

```
- Processor: Intel Core i3 or equivalent
- RAM: 4 GB minimum
- Hard Disk: 1 GB free space
- Monitor: 1024x768 resolution minimum
- Printer: Any standard inkjet/laser printer

```

**Software Requirements**:

```
- Operating System: Windows 10 or later
- .NET Framework: 4.5.2 or above
- Database: SQL Server 2016 or above
- PDF Drivers for report generation

```

### Installation

#### 1. Clone the Repository

```bash
git clone https://github.com/Kanif-Kumbhar/BrickForgeCommander.git
cd BrickForgeCommander

```

#### 2. Database Setup

**Create Database:**

```sql
CREATE DATABASE BrickyardManagement;
GO

USE BrickyardManagement;
GO

```

**Run Database Scripts:**
Execute all SQL scripts in the following order:

```bash
# Navigate to database scripts folder
cd Database/Scripts

# Execute in order:
1. Tables/CreateTables.sql
2. StoredProcedures/CreateProcedures.sql
3. SeedData/InitialData.sql

```

#### 3. Configure Connection String

Update `App.config` with your SQL Server connection details:

```xml
<connectionStrings>
  <add name="BrickyardDB" 
       connectionString="Data Source=YOUR_SERVER;
                        Initial Catalog=BrickyardManagement;
                        Integrated Security=True;
                        MultipleActiveResultSets=True" 
       providerName="System.Data.SqlClient"/>
</connectionStrings>

```

#### 4. Build and Run

**Using Visual Studio:**

1. Open `BrickForgeCommander.sln`
2. Restore NuGet packages
3. Build solution (Ctrl+Shift+B)
4. Run application (F5)

**Using Command Line:**

```bash
# Restore dependencies
nuget restore BrickForgeCommander.sln

# Build solution
msbuild BrickForgeCommander.sln /p:Configuration=Release

# Run executable
cd bin/Release
BrickForgeCommander.exe

```

#### 5. Default Login Credentials

```
Username: admin
Password: admin123

```

**⚠️ Important:** Change default credentials immediately after first login.

---

## 🏗️ System Architecture

### Technology Stack

**Frontend:**

* **Language**: C# with Windows Forms
* **Framework**: .NET Framework 4.5.2+
* **UI Components**: Custom controls and data-bound forms

**Backend:**

* **Database**: SQL Server 2016+
* **ORM**: ADO.NET with stored procedures
* **Authentication**: Role-based access control
* **Reporting**: Crystal Reports / Custom report engine

**Architecture Pattern:**

* **Three-Tier Architecture**
* Presentation Layer (Windows Forms)
* Business Logic Layer (C# Classes)
* Data Access Layer (SQL Server)



### Database Schema

The system uses 29 interconnected tables to manage operations.

**Core Tables:**

* `LoginDetails` - User authentication
* `VendorDetails` - Customers, suppliers, workers, drivers
* `ProductDetails` - Brick products with pricing
* `RawMaterialDetails` - Material inventory
* `Orders` - Customer orders
* `WorkDetails` - Worker production records
* `VehicleDetails` - Fleet management

**Relationship Tables:**

* `OrderDetails` - Order line items
* `ProductRawMaterialDetails` - Product composition
* `DriverAssignmentDetails` - Delivery assignments
* `PartyPaymentDetails` - Payment tracking

---

## 📁 Project Structure

```
BrickForgeCommander/
├── BrickForgeCommander/
│   ├── Forms/                    # Windows Forms UI
│   │   ├── Dashboard.cs
│   │   ├── Login.cs
│   │   ├── Master/              # Master data forms
│   │   ├── Worker/              # Worker management
│   │   ├── RawMaterial/         # Material management
│   │   ├── Production/          # Production forms
│   │   ├── Orders/              # Order processing
│   │   └── Reports/             # Report viewers
│   ├── BusinessLogic/           # Business rules
│   ├── DataAccess/              # Database operations
│   ├── Models/                  # Data models
│   ├── Utilities/               # Helper classes
│   └── Resources/               # Images, icons
├── Database/
│   ├── Scripts/                 # SQL scripts
│   │   ├── Tables/
│   │   ├── StoredProcedures/
│   │   └── SeedData/
│   └── ERD/                     # Database diagrams
├── Documentation/
│   ├── UserManual.pdf
│   ├── TechnicalReport.pdf
│   └── Screenshots/
└── README.md

```

---

## 📊 Features Walkthrough

### Master Data Management

#### 1. Brick Type Configuration

Define various brick types manufactured:

* Red Brick 4x4
* Red Brick 9x4x3
* Red Brick 16x4
* Custom brick specifications

#### 2. Raw Material Setup

Configure raw materials with storage capacity:

* Sand (bulk storage)
* Coal (fuel)
* Lime (binder)
* Saw Dust (additive)
* Water management

#### 3. Worker Organization

* Batch creation and management
* Role assignment (Worker, Supervisor, etc.)
* Worker registration with documents

### Production Operations

#### 1. Brick Payment Configuration

Set task-based pricing:

* **Making**: Mixture preparation charges
* **Dhulai**: Moulding charges per brick
* **Nikashi**: Removal from furnace charges

#### 2. Product Definition

Define products with:

* Raw material composition
* Production costs
* Profit margins
* Credit scores
* Unit pricing

#### 3. Production Tracking

Record daily production:

* Batch-wise production
* Worker-wise performance
* Automatic stock updates
* Wage calculation

### Order Management

#### 1. Order Processing Flow

```
Customer Enquiry → Order Creation → Payment Recording → 
Driver Assignment → Order Dispatch → Delivery → Invoice Generation

```

#### 2. Order Tracking

Monitor orders through stages:

* **In-Queue**: Awaiting processing
* **Dispatched**: Assigned to driver
* **Delivered**: Completed
* **Cancelled**: Order cancelled

### Financial Reports

Generate comprehensive reports:

* **Stock Reports**: Raw material and product inventory
* **Order Reports**: Complete order history
* **GST Reports**: Tax-compliant documentation
* **Profit Reports**: Visual profit analysis
* **Worker Reports**: Productivity and payments
* **Ledger Reports**: Financial transactions

---

## 🔧 Configuration

### Payment Settings

Configure payment methods in `PaymentTypeDetails` table:

```sql
INSERT INTO PaymentTypeDetails (PaymentTypeName) 
VALUES ('Cash'), ('Online'), ('Credit');

```

### GST Configuration

Default GST rate is 12%. Modify in `Order Processing` module:

```csharp
public const decimal GST_RATE = 0.12m; // 12%

```

### Delivery Charges

Set city-wise delivery costs:

```
Vehicle Type | City | Cost per Trip
Truck        | Sangli | ₹200
Dumper       | Shirolaj | ₹300

```

---

## 📱 User Interface

### Dashboard Features

* **Statistics Cards**: Orders, Revenue, Total Profit
* **Revenue Chart**: Visual representation of daily sales
* **Top Products**: Best-selling items
* **Stock Alerts**: Understocked materials highlighted
* **Quick Actions**: Fast access to common operations

### Form Navigation

Intuitive menu structure:

```
Dashboard
├── Master (Configuration)
├── Workers (Labor Management)
├── Raw Materials (Inventory)
├── Vehicle (Fleet Management)
├── Production (Manufacturing)
├── Orders (Sales)
├── Reports (Analytics)
└── Tools (Utilities)

```

---

## 🧪 Testing

### Unit Testing

```bash
# Run unit tests
cd Tests
dotnet test

```

### Integration Testing

Test complete workflows:

* Order creation to delivery
* Raw material purchase to production
* Worker registration to payment

---

## 🤝 Contributing

Contributions are welcome! This project was developed as an academic endeavor and is open for enhancements.

### How to Contribute

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/Enhancement`)
3. Commit your changes (`git commit -m 'Add Enhancement'`)
4. Push to the branch (`git push origin feature/Enhancement`)
5. Open a Pull Request

### Areas for Contribution

* Web-based version development
* Mobile application for field workers
* Advanced analytics and ML integration
* Multi-language support
* Cloud deployment capabilities

---

## 🗺️ Roadmap

### Current Version (v1.0) ✅

* Complete desktop application
* SQL Server database
* Comprehensive reporting
* Worker and order management

### Planned Enhancements

**Version 2.0:**

* [ ] Web-based application for global accessibility
* [ ] Automatic backup and recovery mechanism
* [ ] Enhanced user interface with responsive design
* [ ] Mobile companion app for drivers and workers
* [ ] Integration with accounting software

**Version 3.0:**

* [ ] Cloud deployment (Azure/AWS)
* [ ] Real-time notifications and alerts
* [ ] GIS integration for spatial analysis
* [ ] Advanced analytics with ML predictions
* [ ] Multi-location franchise support

---

## 🎓 Academic Information

**Project Type**: B.Sc. Computer Science (Entire) Final Year Project

**Institution**: Smt. Kasturbai Walchand College, Sangli

**University**: Shivaji University, Kolhapur

**Academic Year**: 2023-24

**Submitted By**:

* Mr. Kadam Ritesh Sunil (PRN: 2021023650)
* Mr. Kumbhar Kanif Maruti (PRN: 2021010543)

**Guided By**: Mrs. S. S. Jadhav

**Coordinator**: Prof. D. A. Patil

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](https://www.google.com/search?q=LICENSE) file for details.

## 👤 Authors

**Kanif Kumbhar**

* GitHub: [@Kanif-Kumbhar](https://github.com/Kanif-Kumbhar)
* LinkedIn: [kanifkumbhar2345](https://linkedin.com/in/kanifkumbhar2345)
* Email: kanifkumbhar@gmail.com

**Ritesh Kadam**

* Collaborative Developer

## 🙏 Acknowledgments

Special thanks to:

* **Mrs. S. S. Jadhav** - Project Guide
* **Prof. D. A. Patil** - Coordinator, Department of B.Sc. Computer Science (Entire)
* **Dr. B. P. Ladgaonkar** - Principal, Smt. Kasturbai Walchand College, Sangli
* Faculty and staff of Computer Science Department
* All teaching and non-teaching staff for their support

## 📚 References

1. Professional C# 2008 by WROX
2. C# 7.0 in a Nutshell
3. Stack Overflow Community
4. SQL: The Ultimate Beginners Guide: Learn SQL Today

---

**⭐ Star this repository if you find it helpful!**

*BrickForge Commander - Transforming traditional brickyard management through technology* 🧱💻📊

---

**©2024 R&K Company. All rights reserved. Generated by BrickForgeCommander.**
