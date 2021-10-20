# AnotherComputationProofForATheoremICameUpWith

Problem: For any problem in which x+y+z =  a given number t, how many non-negative integer solutions are there?

Options:
-Some random formula the prof put on the board
-Brute Forcing(testing every possible pair where the values are less than t, choosing only the ones where the identity is fullfilled and then counting them).
-My Formula:

In a version of this problem with only two variables, it can be solved easily showing t+1 possibilities (in an example where t= 7, for every value between 0-8 for x, there´s one and only one correspoding y value where the identity holds true. As such, call the version with two varaibles P(t), where ∀t>0, P(t) = t+1.

Now, with three variables, z has, logically, t + 1 choices. However, unlike in the situation with only two proofs, for every valid choice of z, there are multiple choices for the remaining two varaibles. Take, for instance, z = 5 and t = 7: since z is already 5, that means that x and y can be a bunch of ordered pairs - they could be (1,1),(0,2), or more. 

In fact, the restraints behind the possibilites for x and y are that, together with 5, the collectively add up to 7. So, we are just left with the two-variable problem version where both values must add up to 7-5, or 2. As such, this can be written as P(2).

Now, we need only sum all all the different possibilites for all values of z. Luckily, for every value chosen for z, the amount of possibilites is just P(t-z). Writing it out, for an example of t = 4, we have P(4-0) + P(4-1) + P(4-2) + P(4-3) + P(4-4). Or, (4+1)+(3+1)+(2+1)+(1+1)+(0+1), or 5+4+3+2+1, which is just a arithemtic sum which goes up to t+1. 

Seeing that the extremes add up to the same, which in this case is 6, and the middle (if t is even) is half of that, we can safely postulate that:

∀t>0, if t%2=1 (if t is odd), the amount of possibilities is (t+2)*(t+1)/2, while if t is even than (t+2)/2 can be added once.

By comparing the answwers computed with this formula to those bruteforced by a computer, they are always the same (up to 1522)




--Note for self: Code compiles in https://replit.com/languages/csharp.
