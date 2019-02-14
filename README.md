# Queen Attack

## Description

In chess, a queen can move horizontally, vertically, and diagonally, making it the most powerful piece on the board. If another piece is within its line of sight along these three lines, the queen may attack it.

Create an app where the user can enter X and a Y coordinates for both a queen, and another chess piece. The program should return whether the queen is capable of 'attacking' this other chess piece.

Hints
When the user submits coordinates, the program should create an instance of a Queen class, with properties for its X and Y coordinates.
The Queen class should have a method that takes X and a Y coordinate as arguments, and returns true if the queen can attack the given space, and false if it cannot.
A message should be displayed to inform the user of the results.
Remember to write your specs in plain english. Don't be tempted to write a single test for the true case (e.g., it 'is true if it can attack horizontally or vertically or diagonally') - there are three separate behaviors here for horizontal, vertical, and diagonal. Also remember to try to refactor or simplify your code as soon as you get something working.

## Specs

* Input Queen coordinates (qx,qy)
* Input Pond coordinates (px,py)

* horizontal = if pond is on the x plane as Queen = true
* vertical = if pond is on the y plane as Queen = true
* diagonal = if |qx - px| = |qy - py| = true
