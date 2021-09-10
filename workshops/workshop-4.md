# Create your own test suite

> Coming soon!

Now that you have implemented simple solutions, complex solutions and fleshed out your own tests it's time to start to think about what you would like to test.

For this workshop you have a near empty solution. There are files there for the test. And a file for the start of your code. But both are empty classes with no information at all.

You need to look at the specifications below, create your tests and turn that into working code using the skills you picked up in the previous two challenges.

At this point a there is a wonderful quote that I've heard time and time again that I would like to introduce.

> How can I possibly write a test when I don't know what code I am going to be writing?

Well... There are two parts that I would like to unpack here.

1. If you do not know what tests you are going to need, then how can you know what code you are going to produce?
2. What is stopping you from experimenting?

The first point is important when writing code. If you do n ot know enough about the code that you are going to be writing, then how can you write deliberate code to solve a problem - and have it remain maintainable in the future? This is what I call thinking with the keyboard, and rarely does it supply long term high quality code. Rather you will keep on chasing the faults until you arrive at something that is working, but not necessarily high quality code that you are going to want to maintain, or build on.

// TODO: Add link to GeePawHill on micro spiking
For the second point I would like to introduce the concept of micro spiking.

You do not know what you need to do to solve your problem. You want to experiment, play with the code and see what works.

So do it. Make a branch and see where it takes you. This  is going to give you one of two insights

1. This works, yay!
2. This is a rabbit hole and I need to get out.

The main thing with a micro-spike is that neither of these outcomes is better than the other. And that is because the only thing that you should be taking from it is: knowledge.

The broken code? Undo the changes `git reset --hard`, remember where you went wrong and try again. Time for a new micro-spike.

That working code? Well, it's not deliberate, so we are not keeping that either. Use your knowledge here to write your tests. Undo your code, and now make your tests pass.

The advantage that we get here is that we know our direction now. We know what tests we want to write. We have failing tests before we have passing tests (very important), and our code is very deliberate.

So, with this in mind onto the challenge!