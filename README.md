### Maths Background

#### Asymptote
* Approaches but never touches as approaches infinity

![image](https://user-images.githubusercontent.com/39176556/223015349-65f6d998-6aff-4a1c-be61-c3753f280997.png)

#### Logarithms
* Inverse operation of exponentiation
* "What power `x` do I need to apply to base `b` to get number `y`?"
  * e.g. log<sub>10</sub>(100) = 2 is the inverse of 10<sup>2</sup> = 100
* Another way to think about it is "how many `b`'s do I need to multiply together to get `y`?"
* Logarithms are a nice way to deal with multiplicative sequences, like something growing at a changing rate
  * Using logarithms, allows a multiplicative sequence to become an additive one (easier to deal with)
    * e.g. If `r = changing rate`: (1+r<sub>1</sub>) * (1+r<sub>2</sub>) * (1+r<sub>3</sub>) becomes log(1+r<sub>1</sub>) + log(1+r<sub>2</sub>) + log(1+r<sub>3</sub>)
  * Nice way to handle some algorithm's growth rates 

### Algorithms

#### General
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
