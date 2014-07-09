IssueTracker
============

An MVC and Entity Framework n-tier example.

I am using this repo as a way to share learning experiences with others. Firstly, I am asking for suggestions on best practices for the following:

* Data layer repository patterns
* Business layer integration with data repositories
* MVC business layer integration
* MVC Model/ViewModel/ViewModelBuilder architecture

I want strict separation of concerns so that means the Web layer should not be able to access the data layer. All requests must be handled in the Business layer and made available to the Web layer. Eventually, there may be a thick client application incorporated which will use the Busines layer interfaces too.

Some things that I think are required here are:
* Dependency Injection

I have done as much as I can so far and have some stumbling blocks. These issues have been created in this repo so feel free to browse the issues list and make alterations accordingly.

Feel free to contribute and share your knowledge.
