IEJST
=====

I originally wrote IEJST ( http://iejst.codeplex.com ) about four years ago, after reading this @jeresig post:
http://ejohn.org/blog/accuracy-of-javascript-time/

I decided to make a simple IE wrapper to expose throught the window.external interface an high resolution timer 
for testing real IE Javascript performance

Now, after reading about @WebReflection https://github.com/WebReflection/preciseTime I just wanted to update that
by adding a native preciseTime function in the same fashion of start/stopBench

