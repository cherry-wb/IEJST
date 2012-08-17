IEJST
=====

I originally wrote IEJST (iejst.codeplex.com) about four years ago, after that @jeresig wrote
http://ejohn.org/blog/accuracy-of-javascript-time/

I decided to make a simple IE wrapper that expose throught the window.external interface an high resolution timer for testing IE Javascript performance

The project will be a very basic .net 3.5 window forms project written with VS 2008 express,
it will require .net 3.5 installed.

Now, after reading about @WebReflection https://github.com/WebReflection/preciseTime I decided to update that
by adding a native preciseTime function in the same fashion of start/stopBench

