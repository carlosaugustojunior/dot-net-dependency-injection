# dot-net-dependency-injection
Code to show how dependency injection works in .NET using Minimal API and .NET 6.

## Dependency injection configuration ##

![image](https://user-images.githubusercontent.com/72868220/191816160-ed1fde6e-0119-40fc-b3ca-2691e28fd27c.png) <br />

## Expected result ##

![image](https://user-images.githubusercontent.com/72868220/191815224-b290e933-d974-4393-9a41-0bea2d41e2df.png)

- firstServiceId - It changes only if you restart the application. <br />
- secondServiceId - It's the same in the request. It'll change in a new request. <br />
- thirdServiceId - It changes every request. <br />

