# tdd-workshop
A set of TDD workshops, from into to complex to help you get started using this tool!

## Lanuages

Currently our workshops are available in C#, and shortly in JS.

If you would like to add a language here, please sub mit a PR - we'd love to have more languages added!

## Prerequisites

### TDD Basics

You should have some afinity with the basics of TDD. This is a great talk to get you started

<a href="https://www.youtube.com/watch?v=6FBmeTGN5Pk" target="_blank">TDD and the Terminator - An introduction to Test Driven Development - Layla Porter - NDC Oslo 2020</a>

### Language Knowledge

You should have a basic afinity with the language that you are writing your tests in.

These workshops focus on the TDD aspect of the development and so we are not using complex objects, patterns or DI.

## Workshops

We have three workshops at present:

* Getting started: FizzBuzz
* Step it up a gear: Mapping objects
* Starting to stand on your own feet: More Object Mapping

As with the language support, if you would like to add a workshop please send us a PR!

### Your first TDD - FizzBuzz

We are starting with FizzBuzz - four simple rules:

* If a number is divisible by 3 return 'Fizz'
* If a number is divisible by 5 return 'Buzz'
* If a number is divisible by 3 and 5 return 'FizzBuzz'
* Otherwise return the number as string

To help you on your journey this workshop includes all tests, and the empty functinon.

You task is to make each of the tests go green in turn.

> Remeber: We want to write the simplest code for each test. Your code should not make more than one test go green for each change that you do. If multiple tests go from red to green with one code change then you've done too much. Undo the change and try again!

Once a test is green it should stay green. If your new code breaks an old test, fix the problem before moving on.

Don't refactor more than you need to ensure that all passing tests remain green whilst working through the workshop. When all tests are green you can do your refactoring!

### Step it up a gear - Object mapping!

After getting your first taste on FizzBuzz lets do something a little more real world for you - an object mapper.

Again, we have made the tests for you, you just need to implemented code code to make those tests pass.

There are some helper functions properties given to you to help you mock the data, and for reference an entire API response so that you can see the structure of the data.

### Write your own tests - Onject Mapping
  
In the first two challanges you've created a simple FizzBuzz fucntion, and written an app to extract data from an API JSON.

For both of these the focus was on the writing of code to make tests pass, and to make the tests pass in the right order!

Now for something a little more complex. We are extracting data from another API here, previously we had our list of summary information for blog posts, here we are fetching on of the blog posts itself.

If you look in the solution you will see that there is still a model for you to use, a function and test file. But that function and test file are a little empty and currently return exceptions and asset that `false == true`

You need to flesh out the tests to do what the description says before implementing the code to make that test pass.

Our helper functions have also dissapeared - these you will need to make yourself - if you decide you want/need them.

A big challange here is to first make sure that you test fails. Not with the `false == true` asertion, but with actual test code.

Finally... Remember to ensure that you are only making one test pass at a time! When writing your own tests it's easy to get caught up in the moment and go too quickly. Good luck!
