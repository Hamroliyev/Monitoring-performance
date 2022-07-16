# Monitoring-performance
Monitoring performance and memory use and Measuring the efficiency of processing strings
There is another metric we should consider: maintenance. This is a
measure of how much effort another programmer would have to put in to
understand and modify your code. If you use a nonobvious type choice
without explaining that choice with a helpful comment, then it might
confuse the programmer who comes along later and needs to fix a bug or
add a feature.
Monitoring performance and memory use
The System.Diagnostics namespace has lots of useful types for
monitoring your code. The first one we will look at is the Stopwatch type:

