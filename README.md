# JumpinFrog (Fibonacci)

The Frog can jump 1 or 2 steps each time.
The problem is to calculate the number of different combinations (1-step or 2-step) the Frog can jump to a given number of steps.

#### Example: 
The frog should jump 3 steps => (1,1,1) (1,2) (2,1) => 3 combinations.

## Fibonacci[^1]
In the example above we actually see one of the Fibonacci series numbers

| F0 |	F1 |	F2 |	F3 |	F4 |	F5 |	F6 | ... F12 |
|----|-----|-----|-----|-----|-----|-----|---------|
| 0  |	1	 |  1	 |  2	 |  3	 |  5	 |  8	 | ... 144 |

But we want to omit the first two (0, 1). Then our table looks like (S = steps):

|	S1 |	S2 |	S3 |	S4 |	S5 | ... S11 |
|----|-----|-----|-----|-----|---------|
|  1 |  2	 |  3	 |  5	 |  8	 | ... 144 |

compare with the example above (S3 = 3).

## The Code
*First a warning about the code. I have never used <code>goto</code> in C#. But I felt this was the program where I have too use it (sorry). It's only used one time.*

As a user you can choose to calculate the number of combinations two ways.
 * Iterative
 * Recursion
 
 Go by feeling and have fun!




[^1]: https://en.wikipedia.org/wiki/Fibonacci_number
