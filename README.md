# coding-challenge
The current project is designed using Visual Studio 2019 IDE.
In order to be able to directly launch the solution without any further conversion, the minimum accepted Visual Studio version must be 10.0.40219.1.
Beside the IDE Version, the developers must install the Microsoft.Net.SDK. The target framework of the application is .net 5.0, and that's the
version we truly recommend in order to obtain the best developing experience starting from the current piece of work.
When it comes to testing project(CodingChallenge.Tests), the previous dependencies are necessary in this case as well. Beside the already presented dependencies,
the NUnit package must be installed within Visual Studio together with an explicit dependecy that points to the main application(CodingChallenge), since 
we're testing the behavior of CodingChallenge's algorithms classes, in order to be able to run the specific tests.
At this point, since the implementation of the three algorithms was not approved yet, the main branch doesn't provide a way of running or testing the desired
functionality of the application. Once the pull requests will be approved and all the secondary branches will be merged to the main branch, there will be an
implementation for each algorithm within its specific class(AlgorithmOne, Two, Three).
Even after merging, running the main application will be pointless, since there is no business logic defined for our application yet (the main method is not
designed to run some specific tasks), it just offers an implementation for each of the required algorithms.
In order to run the NUnit tests, the project solution must be launched using the Visual Studio IDE, then you should:
  1. Click "Test" on the Menu bar
  2. Click "Run All Tests" in order to execute all the tests, which implies testing every algorithm.
