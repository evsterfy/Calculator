Just a project I am testing myself on. The C++ console version probably won't be updated any further.

If you want, you can try out the .exe and try to break the calculator and let me know what equation you tried. I don't have the time and will power to try too many equations.

Currently supports roots, logs, sin/cos/tan, e, Pi, and implicit multiplication.

April 2019
-
Added Richardson's Extrapolation in the drop down 'File' menu. Takes a function using 'x' then asks for value of 'x' to solve for and step size. Then replaces all 'x' chars with relative values, (x + h) and (x - h) and using the main calculator to solve the function with those values and perform extrapolation order n formula to solve all the way to O(h^8), resulting in a very accurate estimate of the derivate of the function at the value of 'x'.

May 2019
-
Added Interpolation using Composite Simpson's Rule.
