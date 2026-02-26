# Siemens Internship Problem Solutions

Solutions for the online assessment (Coffee Shop digitization + SieMarket store).

---

## Problem 1: Coffee Shop Digitization

**Location:** [`diagrams/`](diagrams/)

| Task | File | Description |
|------|------|-------------|
| **1.1 Class diagram** | [class-diagram.png](diagrams/class-diagram.png) | Classes, relationships, properties, and methods for beverages, sizes, extras, loyalty program, baristas, and orders. |
| **1.2 Database (ER) diagram** | [db-diagram.png](diagrams/db-diagram.png) | Tables, columns, primary keys, and foreign keys for the same domain. |

Open the PNG files in the `diagrams` folder to view the solutions.

---

## Problem 2: SieMarket Online Store

**Location:** [`src/`](src/)

| Task | Where it is | What it does |
|------|-------------|--------------|
| **2.1 C# classes** | `Customer.cs`, `Order.cs`, `OrderItem.cs` | Domain model: customer, order, and order items (product name, quantity, unit price). |
| **2.2 Final price** | `Order.GetFinalPrice()` in [Order.cs](src/Order.cs) | Sums item totals; applies 10% discount when order total > 500€. |
| **2.3 Top spending customer** | `OrderService.GetCustomerWithMostSpent()` in [OrderService.cs](src/OrderService.cs) | Returns the name of the customer with the highest total spend across all orders. |
| **2.4 Popular products (bonus)** | `OrderService.GetPopularProducts()` in [OrderService.cs](src/OrderService.cs) | Returns the top N products by total quantity sold. |

### Files in `src/`

- **Customer.cs** — `Id`, `Name`
- **Order.cs** — `Id`, `Customer`, `OrderItems`, `GetFinalPrice()`
- **OrderItem.cs** — `Id`, `ItemId`, `ProductName`, `Quantity`, `UnitPrice`
- **OrderService.cs** — `GetCustomerWithMostSpent(orders)`, `GetPopularProducts(orders, topN)`

### Running the C# code

The `src` folder contains plain C# files. To run or test them:

- Create a C# console or test project (e.g. with `dotnet new`) and add these files, or  
- Open the folder in Visual Studio / Rider and add the files to a project.

No extra dependencies are required; the code uses only the standard library.
