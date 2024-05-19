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
  

### Pages

<div align="center">
   <img width="257" alt="login" src="https://github.com/NANITH777/Food4Life/assets/109669139/0088219e-66fd-4078-88a0-ca9836b58fe8">
   <img width="400" alt="Acceuil" src="https://github.com/NANITH777/Food4Life/assets/109669139/18cda5b1-6d47-4050-8f3c-0ddf34472951">
   <img width="400" alt="Yemek Ekle" src="https://github.com/NANITH777/Food4Life/assets/109669139/65ce8f06-d0eb-4103-a66b-8a5123995c39">
   <img width="400" alt="yemek Guncelle" src="https://github.com/NANITH777/Food4Life/assets/109669139/1c524ea4-a077-4f74-a69f-abc9952db9df">
   <img width="400" alt="siparis" src="https://github.com/NANITH777/Food4Life/assets/109669139/6a87ea9c-bcb6-4d44-8bd2-4ead252f5473">
   <img width="400" alt="fatura" src="https://github.com/NANITH777/Food4Life/assets/109669139/5baa7c24-f3e8-4c3d-bee8-e78f650c9022">
   <img width="400" alt="listele" src="https://github.com/NANITH777/Food4Life/assets/109669139/fc07f9a3-1653-4e6d-b9ae-43690ed19b79"> 
</div>
   

