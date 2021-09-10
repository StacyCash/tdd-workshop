# Step it up a gear - Object mapping

After getting your first taste on FizzBuzz lets do something a little more real world for you - an object mapper.

Here are are trying to make something a little more real world.

We have a data source that provides us a rich list of blog post summaries, in JSON form.
We want to convert that to an internal format for use further down the application chain.

Our code for this workshop is going to concern itself with the adaption of the JSON string into an array of internal objects.

We only want a small number of fields from the data source to be converted, those fields have different names (and maybe types) - and there are rules for when the adaption should throw an error if the input isn't valid.

Again, we have made the tests for you, you just need to implemented code code to make those tests pass.

> As with the first workshop, implement just enough code to make the test that you are working on pass (without breaking any tests that you already have green).<br/> Once you have implemented all the code that is needed to turn all tests green try your hand at refactoring the code. One thing to notice is when refactoring you always have a view on whether you have broken anything because of the tests that we have available for us.

There are some helper functions and properties given to you to help you mock the data, and for reference an entire API response of the data source so that you can see the structure of the data.
