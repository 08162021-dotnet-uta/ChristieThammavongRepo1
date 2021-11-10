# Coding Challenge Description

## JavaScript

### Challenge 1
This robot roams around a 2D grid. It starts at (0, 0) facing North. After each time it moves, the robot rotates 90 degrees clockwise. Given the amount the robot has moved each time, you have to calculate the robot's final position.

To illustrate, if the robot is given the movements 20, 30, 10, 40 then it will move:

20 steps North, now at (0, 20) <br>
30 steps East, now at (30, 20) <br>
10 steps South. now at (30, 10) <br>
40 steps West, now at (-10, 10) <br>
...and will end up at coordinates (-10, 10).

Examples:

trackRobot(20, 30, 10, 40) ➞ [-10, 10]

trackRobot() ➞ [0, 0]
// No movement means the robot stays at (0, 0).

trackRobot(-10, 20, 10) ➞ [20, -20]
// The amount to move can be negative.

Notes <br>
Each movement is an integer (whole number).

### Challenge 2
Your task is to create a function that simulates a vending machine.

Given an amount of money (in cents $ to make it simpler) and a productNumber, the vending machine should output the correct product name and give back the correct amount of change.

The coins used for the change are the following: [500, 200, 100, 50, 20, 10]

The return value is an object with 2 properties:

- product: the product name that the user selected.
- change: an array of coins (can be empty, must be sorted in descending order).

Examples: <br>
vendingMachine(products, 200, 7) --> { product: "Crackers", change: [ 50, 20, 10 ] }

vendingMachine(products, 500, 0) --> "Enter a valid product number"

vendingMachine(products, 90, 1) --> "Not enough money for this product"

Notes:

- If 'productNumber' is invalid (out of range) you should return the string: "Enter a valid product number".
- If 'money' is not enough to buy a certain product you should return the string: "Not enough money for this product".
- If there's no change, return an empty array as the 'change'.