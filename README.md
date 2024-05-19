# Food4Life (Restaurant Menu Management System)

This project is a comprehensive Restaurant Menu Management System developed using C# and Windows Forms. The system is designed to manage the menu items of a restaurant, handle orders, and maintain inventory of ingredients. It includes functionalities for adding, updating, and deleting menu items and ingredients, as well as generating various reports.

## Features

1. **Menu Item Management**:
   - **Base Class**: A `Yiyecek` (Food) class is created with fields such as `adi` (name), `cins` (type), `fiyat` (price), `kdvoranı` (VAT rate), etc.
   - **Derived Classes**: 
     - `Salata` (Salad)
     - `Tatlı` (Dessert)
     - `İçecek` (Drink)
     - `Yemek` (Meal)
     - `Meyve` (Fruit)

2. **Order Management**:
   - `Siparis` (Order) class with methods to add, remove, and print orders.

3. **Inventory Management**:
   - `depo.txt`: A file to record ingredients used in the dishes. 
   - `Urun` (Product) class with fields such as `urunAdi` (product name), `UretimTarihi` (production date), `sonKullanmaTarihi` (expiry date), `kaloriGram` (calories per gram), `StokAdet` (stock quantity), and `fiyat` (price).
   - Operations for adding, deleting, updating, and reporting records.

4. **Dish Management**:
   - `yemekcesit.txt`: A file to store at least 20 different dishes.
   - `malzeme.txt`: A file to store the ingredients used for each dish.
   - Operations for adding, deleting, updating, and reporting dishes and their ingredients.

5. **Daily Operations**:
   - Determine daily production for each dish and the required ingredients.
   - Manage sales of dishes throughout the day.
   - Generate reports on produced, sold, and remaining dishes, as well as cost and profit analysis.

### Prerequisites

- Visual Studio (or any other C# IDE)
- .NET Framework

### Installation

1. Clone the repository:
   ```bash
   git clone [repository URL]
   ```
2. Open the solution file (`RestaurantMenuSystem.sln`) in Visual Studio.
3. Build the project to restore the necessary packages.

### Usage

1. **Menu Management**:
   - Use the provided forms to add, update, or delete menu items and their details.

2. **Order Management**:
   - Manage customer orders using the `Siparis` class functionalities.

3. **Inventory Management**:
   - Maintain the `depo.txt` file using the provided operations to manage ingredients.

4. **Dish Management**:
   - Update the `yemekcesit.txt` and `malzeme.txt` files as needed to manage dishes and their ingredients.

5. **Daily Operations**:
   - Generate reports and manage daily operations using the provided methods to track production, sales, and inventory.

