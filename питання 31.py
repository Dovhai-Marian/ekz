class Product:
    total_products = 0 

    def __init__(self, name, price):
        self.name = name
        self.price = price
        Product.total_products += 1

    def display_info(self):
        return f"Name: {self.name}, Price: ${self.price}, Total Products: {Product.total_products}"


class ElectronicProduct(Product):
    def __init__(self, name, price, warranty_period):
        super().__init__(name, price)
        self.warranty_period = warranty_period

    def display_info(self):
        return f"Name: {self.name}, Price: ${self.price}, Warranty: {self.warranty_period} months, Total Products: {Product.total_products}"


class ClothingProduct(Product):
    def __init__(self, name, price, size):
        super().__init__(name, price)
        self.size = size

    def display_info(self):
        return f"Name: {self.name}, Price: ${self.price}, Size: {self.size}, Total Products: {Product.total_products}"


if __name__ == "__main__":
    product1 = Product("Phone", 500)
    electronic_product1 = ElectronicProduct("Laptop", 1200, 12)
    clothing_product1 = ClothingProduct("T-shirt", 20, "M")

    print(product1.display_info())
    print(electronic_product1.display_info())
    print(clothing_product1.display_info())

    print(f"Total products created: {Product.total_products}")
