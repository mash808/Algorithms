### Maths Background

#### Asymptote
* Approaches but never touches as approaches infinity

![image](https://user-images.githubusercontent.com/39176556/223015349-65f6d998-6aff-4a1c-be61-c3753f280997.png)

#### Logarithms
* Inverse operation of exponentiation
* "What power `x` do I need to apply to base `b` to get number `y`?"
  * e.g. log<sub>10</sub>(100) = 2 is the inverse of 10<sup>2</sup> = 100
* Another way to think about it is "how many `b`'s do I need to multiply together to get `y`?"
* Logarithms allows for multiplicative sequences to become additive ones (easier to deal with)
    * e.g. If `r = changing rate`: (1+r<sub>1</sub>) * (1+r<sub>2</sub>) * (1+r<sub>3</sub>) becomes log(1+r<sub>1</sub>) + log(1+r<sub>2</sub>) + log(1+r<sub>3</sub>)
    
##### Use in Algorithms
* Logarithmic time shows change in the growth rate slightly decreasing as the input size grows
  * e.g. Binary search, where for every doubling of the input size, the operations required only increases by 1.

#### Polynomials
* Polynomials means "many terms"
  * Poly -> "many"
  * Nomial -> "name" or "term" in this case
* Polynomials are expressions that have one or more terms (*binomials* are polynomials with two terms, *trinomials* have three terms, etc.)
  * Each have a constant multiplied by one or more variables raised to a nonnegative power e.g. a + bx + cx<sup>2</sup>
* The `terms` are seperated by signs e.g. In a + bx + cx<sup>2</sup>, `a`, `bx`, and `cx²` are the terms
* `Expressions` are the grouping of terms.

##### Use in Algorithms
* We see polynomials all the time in algorithm analysis
* `T(n) = 3 + (2 + 3) * (n - 1) + 1 = 5n - 1` would be an example of a polynomial in algorithm analysis
  * `T(n)` is a function representing the running time of an algorithm with `n` being the size of it's input
  * The constants in this polynomial are the time that each timed bit of code takes to complete in microseconds

### Algorithms

#### General
> An algorithm is a sequence of unambigous instructions for solving a problem
* Get required output for any legitimate input in a finite amount of time
* Algorithms are independent from programming languages
  * Can be implemented using a programming language, however

<img width="269" alt="Screenshot 2023-03-06 at 3 12 03 pm" src="https://user-images.githubusercontent.com/39176556/223024446-33a1e57e-ea93-4107-93d6-7b3138d7b7ca.png">

#### Pseudocode
* A way to describe an algorithm without having to worry about language-specific details

#### Pseudocode Notation
```
* v, w, ... : variable names
* E, F, ... : expressions
* B, C, ... : boolean-valued expressions
* S, T, ... : (compound) program statements
* P, Q, ... : procedure names

* Expressions: (2 * v) + x
* Parameterised procedure declarations: P(x, y, ...) S
* Procedure calls: P(E, F, ...)
* Returned values: return E
* Informal bits: "obvious" actions e.g. "swap" in some sorting algorithms
* Assignment: v ⬅ E
* Sequential composition: S T or S; T
* Choice: if B S else T
* Iteration (pre-tested): while B do S
* Iteration (post-tested): repeat S until B
* If-then statements (one-armed): if B S
* For loops: for v ⬅ N to M do S
* Primitive types (numbers, characters, Booleans, etc.): 3.14, 'c', true
* Arrays (vectors): A[i]
* Sets: {4, ..., 10}
```

##### Example
```
ALGORITHM ArrayMax(A[0..n-1])
  // Given an array A, of length n >= 1, returns
  // the value of the largest number in A
  max ⬅ A[0]
  for i ⬅ 1 to n - 1 do
    if A[i] > max
      max ⬅ A[i]
  return max
```
 

#### Performance / Efficiency
* Worried about performance of an algorithm (running time & memory space)
  * Time and space complexity
* If measuring time algorithm has taken (or space data structure takes up in memory), can vary from machine to machine

#### Asymptotic Notation
* Can categorise the growth rates of algorithms with regard to the input
  * Allows us to compare different algorithm's efficiency to solve a problem
<img width="501" alt="Screenshot 2023-03-06 at 1 55 08 pm" src="https://user-images.githubusercontent.com/39176556/223016634-ddcfc65b-5df7-4c6e-b662-f44af3386cb3.png">

* Before n<sub>0</sub> doesn't matter
* Usually interested in worst-case, the upper bound (Big-Oh) i.e. doesn't exceed bounding function
* Differ by some constant amount, which gets smaller and smaller as the input grows larger
  * So we can ignore the constant factor difference and use these notations to make comparisons of algorithms easier

#### Common Growth Rates
* N = input

![image](https://user-images.githubusercontent.com/39176556/223018262-2856e510-dd71-4720-8d50-2ac709246362.png)
