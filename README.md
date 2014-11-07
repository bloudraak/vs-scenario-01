vs-scenario-01
==============

Assume that you have an evolving codebase, over 1000+ projects.  Builds take forever. 
Visual Studio can't open a solution with 1000+ projects. As a result, the codebase is broken into 100+ solutions and projects are
updated to use file references instead. 

At this point, MSBuild, even the one with Visual Studio 2013 no longer has the intelligence to work out which project is dependent on which.
This project shows that MSBuild would actually try and build solutions based on the order they appear in the ItemGroup, rather than
actually work out the dependencies. 

We need a makemake.

