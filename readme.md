Unit Testing Lunch and Learn examples
========================================

Here are the examples from the lunch and learn.

How to run tests:
-------------------
- MsTest are run as normal from the Test Explorer window
- NSpec tests are run by eecuting the command ```& '.\Run NSpec tests.ps1'``` in the Package Manager Console 
  -  *Note: There are extensions out there to allow NSpec to run in VS's Test Explorer window, 
  but they weren't working right for me when I put this together. 
  I expect these to be a minor fix to work with VS 2015 so I wouldn't consider that to be a significant hurdle.*
- SpecFlow tests require the SpecFlow VS extension, and then can be run from the Test Explorer window
