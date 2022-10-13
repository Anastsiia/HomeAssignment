# HomeTest

Ex 01

Create console application project
Complete implementation for RandomFactory<T> class.
The purpose of this class to give control to users to get random values of “T” type.
Pay attention that after indexing, the users of this object can remove elements from “T” collection, so there can be a case that the index is not preserved in continuous order.

Ex 02

Create console application project
Create ContactBL class .
Create BaseExecutor abstract class that implements interface IExecute, with Execute method that receives int argument and returns string.
Create ExecutorFactory that receive int argument and return implementation for BaseExecutor by logic given below. (each implementation must be a class):
  If int is 1 then implementation return “option 1”
  If int is 2 then implementation return “option 2”
  If int is 3 then the two implementations above returned.
In ContactBL add function ExecuteAgeLogic that receives int and returns the value by calling ExecutorFactory.
The outputted string for each implementation must begin with a new line (except the first one)

Ex 03

Write a method with complexity of 0(n), that receives unordered array of integers.
And returns the start and end index of the range that has the maximum summary amount.
Example:

[3, -1, 4, -8, 2] - > start = 0, end = 2 (3, -1, 4)
[-5, -3, -2, -7] -> start = 2, end =2 (-2)

