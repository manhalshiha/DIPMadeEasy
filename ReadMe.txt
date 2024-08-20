Invert depnedency principle:
===========================
1- must decouple high level model from low level mode
2- invert dependency meant high levet and low model must depend on the abstraction , must dont concern about detailes .
3- be warry about obsession of invertion , some times must maintain the cohesion , it is important 
4- abstraction is owned by client , so interfaces is at client side , the layer which consume implementation is own the interface whilest		the implementer layer owns the implementation like ( application layer own interfaces while infrastructure layer own implement).
5- dependency injection : client cann't create instanse from object which have implementation for interface , so client needs to way to			consuem those impelmentation , and then client must use dependency injection or locator services .


build our Ioc container :
==========================
1-when we want to inheritance away we use interfaces whileast when we want to inheritance whithin the same layer then we use abstract class
2-when we need to ioc container in our project,we won't could to reference IoC project from client's project (App project ) because it is		circular reference and that is not allowed in dotnet , to solve that we must to create IoCAbstraction project then we include the		interface in it , then make refrence to this abstraction from all our projects .
