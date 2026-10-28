Electricity Bill Calculator (C#)

📌 Project Description
The Electricity Bill Calculator is a simple C# console application that calculates an electricity bill based on the total electricity units consumed.

The program uses an array of unit values, calculates the total consumption, and applies different charges according to the number of units used. An additional 10% surcharge is applied when the total consumption exceeds 101 units.

✨ Features
- Calculates total electricity consumption.
- Uses an array to store electricity unit values.
- Validates unit values using exception handling.
- Applies different rates based on electricity consumption.
- Adds a 10% surcharge when applicable.
- Displays the total units and final electricity bill.

🛠️ Technologies Used
- Programming Language: C#
- Framework:.NET
- IDE: Microsoft Visual Studio

⚙️ How It Works
1. The program stores electricity unit values in an array.
2. It converts the values into integers and calculates the total units.
3. It calculates the bill according to the applicable unit ranges.
4. It adds a 10% surcharge if the total units exceed 101.
5. It displays the total units and final bill.

🧮 Electricity Charge Structure

First 90 units = Rs. 3 
Next 60 units = Rs. 5 
Next 50 units = Rs. 15 
Above 200 units = Rs. 25 

Additional charge:A 10% surcharge applies when total consumption exceeds 101 units.

▶️ How to Run the Project

1. Clone or download this repository.
2. Open the project in Microsoft Visual Studio.
3. Build the project.
4. Run the program using `Ctrl + F5`.
5. View the total electricity units and bill in the console.

Docker is not required to run this as a normal C# console application.

## 💻 Sample Output

For the sample unit values provided in the program:

```text
Total Units: 215
Total Bill: 2282
```

## 🎯 Learning Objectives
- Understand arrays in C#.
- Practise loops and conditional statements.
- Perform calculations using integers.
- Handle exceptions using `try-catch`.
- Develop a simple console-based application.

## 👩‍💻 Author
Wimansi Dissanayaka

## 📄 License
This project is intended for educational and learning purposes.
