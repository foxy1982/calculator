#  Stage 1: The template

There's no tasks in this stage, it's simply to get familiar with our simple calculator application.  It's a very basic console application that will prompt for a calculation to perform.  It can be any of add, subtract, multiply and divide, and the numbers should be separated from the operator by spaces.  It will only deal with integers for simplicity.  For example, putting in `4 x 4` will return `16`.  The program will then exit when you press `enter`.

The important takeaway from the code is that there are only two classes, `Program` and `Calculator`.  `Program` is responsible for taking the input from the UI and passing onto the `Calculator`. `Calculator` turns this input string into a number response.  `Program` then outputs this to screen for the user.
