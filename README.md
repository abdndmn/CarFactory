# Car Factory Simulation

This project simulates a car factory where users can create cars with specific attributes and manage a list of produced cars. The program includes input validation and ensures proper handling of user inputs.

---

## Features

### **Car Class**
The `Car` class represents a car with the following properties:
- **ProductionDate**: Automatically set to the current date and time when the car is created.
- **SerialNumber**: A unique identifier for the car.
- **Brand**: The manufacturer of the car.
- **Model**: The model of the car.
- **Color**: The color of the car.
- **DoorCount**: The number of doors the car has (validated to ensure it is a numeric value).

### **Main Program**
The main program allows users to:
1. Decide whether to create a new car or exit the program.
2. Input details for each car, including `SerialNumber`, `Brand`, `Model`, `Color`, and `DoorCount`.
   - **Input Validation**:
     - Ensures the user inputs a valid integer for `DoorCount`.
     - Re-prompts the user for valid input if an invalid value is entered.
3. Store created cars in a list.
4. Display all cars' `SerialNumber` and `Brand` when exiting the program if any cars have been created.

---

## Program Flow
1. The program asks the user if they want to create a new car.
   - Input `E` (or `e`): Starts the car creation process.
   - Input `H` (or `h`): Exits the program.
   - Invalid input prompts an error message and re-asks the question.

2. For each car:
   - The `ProductionDate` is automatically set.
   - User is prompted to enter details like `SerialNumber`, `Brand`, `Model`, `Color`, and `DoorCount`.
   - The car is added to the `cars` list once all details are entered correctly.

3. When the user chooses to exit (`H`), the program prints the `SerialNumber` and `Brand` of all cars in the `cars` list.

---

## Example Usage

### Input:
```
Araba üretmek istiyor musunuz? (E/H):
E
Arabanın seri numarsını giriniz!
12345
Arabanın markasını giriniz!
Toyota
Arabanın modelini giriniz!
Corolla
Arabanın rengini giriniz!
Beyaz
Arabanın kapı sayısını giriniz!
4
Araba üretildi!

Araba üretmek istiyor musunuz? (E/H):
H
```

### Output:
```
Seri Numarası: 12345, Marka: Toyota
Program sonlandırıldı.
```

---

## Concepts Demonstrated

### **Object-Oriented Programming**
- Encapsulation through the `Car` class.
- Reusability of the `Car` objects.

### **Input Validation**
- Ensures valid input for `DoorCount` using `try-catch`.

### **Loops and Conditional Logic**
- Handles user interaction and repeats the car creation process until the user decides to stop.

### **Collections**
- Uses a `List<Car>` to store multiple car objects dynamically.

---

## How to Extend
- Add additional properties (e.g., `EngineType`, `Price`).
- Save and load the car list from a file.
- Implement sorting and filtering functionality (e.g., by `Brand` or `ProductionDate`).

---

This project is an excellent demonstration of user input handling, validation, and object-oriented principles in C#. Feel free to extend and customize it further!

